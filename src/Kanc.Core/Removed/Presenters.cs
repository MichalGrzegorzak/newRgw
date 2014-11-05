//namespace Effectus.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using Commands;
    using Model;    

	public class Presenters
	{		
        public static IPresenter Show(string name, params object[] args)
		{
			var instance = CreateInstance(name, args);

			instance.Show();

            return instance;
		}

		public static T ShowDialog<T>(string name, params object[] args)
		{
			var instance = CreateInstance(name, args);

			instance.ShowDialog();

			return (T)instance.Result;
		}

		private static IPresenter CreateInstance(string name, object[] args)
		{
			var presenterType = Assembly.GetExecutingAssembly().GetType("Effectus.Features." + name + ".Presenter");
            if (presenterType == null)
				throw new InvalidOperationException("Could not find presenter: " + name);
            var presenterInstance = (IPresenter)Activator.CreateInstance(presenterType);

            //bug - DON'T do this, it creates anther instance of the View that is different than the one created by 
            //bug - the AbstractPresenter class in it ctor(), this caused a wierd bug that took ages to find!!!!!!
            //bug - just access the view that the presenter creates instead!!!!
            //var viewType = Assembly.GetExecutingAssembly().GetType("Effectus.Features." + name + ".View");
            //if (viewType == null)
            //    throw new InvalidOperationException("Could not find view: " + name);
            //var viewInstance = (IView)Activator.CreateInstance(viewType);

            WireEvents(presenterInstance);
            WireButtons(presenterInstance);            
            WireViewBindings(presenterInstance);            			
            //WireViewUpdateControls(presenterInstance);            
			//WireListBoxesDoubleClick(instance);

			if (args != null && args.Length > 0)
			{
				var init = presenterType.GetMethod("Initialize");
				if(init == null)
					throw new InvalidOperationException("Presenter to be shown with argument, but no initialize method found");

				init.Invoke(presenterInstance, args);
			}
			return presenterInstance;
		}      

        /// <summary>
        /// Here the convention is that a button called "Test" is wired up to the "OnTest() function
        /// in the Presenter. Also the function "CanTest()" in the Presenter determines if the "Test"
        /// button is enabled (can be clicked on).
        /// </summary>
        /// <param name="presenter"></param>
		private static void WireButtons(IPresenter presenter)
		{
			var presenterType = presenter.GetType();
            var methodsAndButtons =
                    from method in GetParameterlessActionMethods(presenterType)
                    let elementName = method.Name.Substring(2)                        
                    let matchingControl = GetSpecifiedControl<Button>(presenter.View, elementName)                    
                    let fact = presenterType.GetProperty("Can" + elementName)
                    where matchingControl != null
                    select new { method, fact, button = matchingControl };            

			foreach (var matching in methodsAndButtons)
			{
				var action = (Action)Delegate.CreateDelegate(typeof(Action),
															  presenter, matching.method);
				Fact fact = null;
                if (matching.fact != null)
                {
                    fact = (Fact)matching.fact.GetValue(presenter, null);
                    //Wire up the button.enabled property to the Fact, so that if CanMoveNext returns true
                    //the button MoveNext.Enabled property will be true
                    matching.button.DataBindings.Add("Enabled", fact, "Value", 
                                                    false, DataSourceUpdateMode.OnPropertyChanged);                
                }

			    //Call the method to test out the wiring!!
                //action();
				                
                var delegateCommand = new DelegatingCommand(action, fact);
                matching.button.Click += (sender, args) =>
                    {
                        Trace.WriteLine("Button click: " + ((Button)sender).Name +
                                            ", CanExecute = " + delegateCommand.CanExecute(null));
                        if (delegateCommand.CanExecute(null))
                            delegateCommand.Execute(null);
                    };
			}
		}

        /// <summary>
        /// Using the INotifyPropertyChanged mechanism, wire up a public property on the Presenter to a label with
        /// the same name on the View. 
        /// I.e. a label called "labelStatusInfo" will automaticially update it's "Text" property to
        /// match the value of the "StatusInfo" public property on the Presenter.
        /// </summary>
        /// <param name="presenter"></param>
        private static void WireViewUpdateControls(IPresenter presenter)
        {
            var presenterType = presenter.GetType();
            var methodsAndLabels =
                    from property in GetPublicWritableProperties(presenterType)
                    let propertyName = property.Name
                    where property.PropertyType.IsGenericType
                    let propertyType = property.PropertyType.GetGenericArguments()[0]
                    //TODO this doesn't handle the case where there are 2 matching contorls.
                    // i.e. labelCurrentTime and dateTimePickerCurrentTime with elementName = "CurrentTime"
                    // only 1 will be found!!!
                    let matchingControl = GetSpecifiedControl(propertyType, presenter.View, propertyName)
                    where matchingControl != null
                    select new { control = matchingControl, property };

            foreach (var matching in methodsAndLabels)
            {
                Trace.WriteLine(string.Format("** Found control \"{0}\" that matches with presenter property \"{1}\"",
                                matching.control.Name, matching.property.Name));
                //Bind the property on the View to the label using "DataBindings" and INotifyPropertyChanged
                matching.control.DataBindings.Add("Text", presenter, matching.property.Name + ".Value",
                                                false, DataSourceUpdateMode.OnPropertyChanged);                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="presenter"></param>
        private static void WireViewBindings(IPresenter presenter)
        {
            if (!(presenter.View is IView))
                return;

            var view = presenter.View as IView;
            var bindings = view.Bindings();
            var bindingItem = view.BindingItem();            

            if (bindings.Count <= 0) 
                return;            

            //Clear out any old binindgs (there shouldn't be any but just in case
            foreach (var binding in bindings)
            {
                binding.GuiControl.DataBindings.Clear();
            }

            var presenterType = presenter.GetType();
            var foundBindings =
                from property in GetPublicWritableProperties(presenterType)
                from binding in bindings
                where bindingItem == property.Name
                where property.PropertyType == typeof(Observable<ToDoAction>)                
                from valueProperty in property.PropertyType.GetProperties()
                from internalProperty in valueProperty.PropertyType.GetProperties()
                where internalProperty.Name == binding.SourceItem
                select new { binding, property = internalProperty }; //, parentProperty = property };

            foreach (var item in foundBindings)
            {                    
                Trace.WriteLine("** Binding: " + item);
                item.binding.GuiControl.DataBindings.Add(item.binding.Value,
                                                         presenter,                                                        
                                                         bindingItem + ".Value." + item.binding.SourceItem,
                                                         false,
                                                         DataSourceUpdateMode.OnPropertyChanged);                

                //foreach (Binding dBind in item.binding.GuiControl.DataBindings)
                //{
                //    Trace.WriteLine("Control: "+ item.binding.GuiControl.Name);                    
                //    Trace.WriteLine(dBind.PropertyName + " -> " + dBind.DataSource + " is binding = " + dBind.IsBinding);
                //}
            }
        }      
        
		/// <summary>
		/// Here we simply match methods on the presenter to events on the view
		/// The convention is that any method started with "On" and having no parameters
		/// will be matched with an event with the same name (without the On prefix)
		/// assuming that the event is of EventHandler type.
		/// </summary>
		private static void WireEvents(IPresenter presenter)
		{
			var viewType = presenter.View.GetType();
			var presenterType = presenter.GetType();
			var methodsAndEvents =
					from method in GetParameterlessActionMethods(presenterType)
					let matchingEvent = viewType.GetEvent(method.Name.Substring(2))
					where matchingEvent != null                    
					where matchingEvent.EventHandlerType == typeof(EventHandler)
					select new { method, matchingEvent };

			foreach (var methodAndEvent in methodsAndEvents)
			{
				var action = (Action)Delegate.CreateDelegate(typeof(Action),
															  presenter, methodAndEvent.method);

                Trace.WriteLine(string.Format("** Found a matching function {0}() for the {1} event",
                                methodAndEvent.method.Name, methodAndEvent.matchingEvent.Name));

			    if (action == null) continue;

			    var handler = (EventHandler) ((sender, args) => action());
			    methodAndEvent.matchingEvent.AddEventHandler(presenter.View, handler);
			}
		}

        private static Control GetSpecifiedControl(Type t, Control form, string elementName)
        {
            Trace.WriteLine("ElementName = " + elementName);
            foreach (var viewControl in form.Controls)
            {                                
                var controlImpl = viewControl as Control;
                if (controlImpl == null) continue;

                Trace.WriteLine("\tControl name = " + controlImpl.Name);
               
                var controlName = controlImpl.Name;
                if (viewControl is Button)
                {
                    controlName = controlImpl.Name.Replace("button", "");
                }
                else if (viewControl is Label)
                {
                    controlName = controlImpl.Name.Replace("label", "");
                }
                else if (viewControl is DateTimePicker)
                {
                    controlName = controlImpl.Name.Replace("dateTimePicker", "");
                }

                if (controlName == elementName)
                {
                    return controlImpl;
                }
            }

            return null;
        }

        private static T GetSpecifiedControl<T>(Control form, string elementName) where T : Control        
        {
            return (T)GetSpecifiedControl(typeof(T), form, elementName);          
        }    

		private static IEnumerable<MethodInfo> GetActionMethods(IReflect type)
		{
			return from method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
				   where method.Name.StartsWith("On")
				   select method;
		}

		private static IEnumerable<MethodInfo> GetParameterlessActionMethods(IReflect type)
		{
            return from method in GetActionMethods(type)
                   where method.GetParameters().Length == 0
                   select method;
		}

        private static IEnumerable<PropertyInfo> GetPublicWritableProperties(IReflect type)
        {
            var publicProperties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return from property in publicProperties
                   where property.CanWrite
                   select property;          
        }
	}
}