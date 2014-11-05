﻿using System;
using System.Windows.Forms;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Engine.ViewManager;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Tasks;

namespace Kanc.MVP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            CreateTestData();

            MVCConfiguration cfg = OutlookLikeViewsManager.GetDefaultConfig();
            //cfg.ViewsAssemblies.Add(Assembly.Load(
            //        "Kanc.MVP.SeparateViews"));

            cfg.TaskInfoProviderType = typeof(TaskInfoByAttributesProviderEx);
            cfg.ViewInfosProviderType = typeof(ViewInfosPrividerEx);
            (new TasksManager(cfg)).StartTask(typeof(MainTask));
            Application.Run(Application.OpenForms[0]);
        }

        private static void CreateTestData()
        {
            Customer.AllCustomers.Add(new Customer("John"));
            Customer.AllCustomers.Add(new Customer("Paul"));
            Customer.AllCustomers.Add(new Customer("Snow"));

            Customer.AllCustomers[0].Orders.Add(new Order(1));
            Customer.AllCustomers[0].Orders.Add(new Order(2));
            Customer.AllCustomers[0].Orders.Add(new Order(3));

            Customer.AllCustomers[1].Orders.Add(new Order(4));
            Customer.AllCustomers[1].Orders.Add(new Order(5));
        }
    }
}