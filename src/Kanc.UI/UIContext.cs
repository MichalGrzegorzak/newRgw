using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FizzWare.NBuilder;
using Kanc.Commons;
using Kanc.Core.Entities;
using Kanc.Core.Features;
using Kanc.UI.Forms;
using NHibernate;
using NHibernate.Validator.Engine;

namespace Kanc.UI
{
	public abstract class UIContext
	{
	    public static MainForm MainForm;
	    public static bool UITesting = false;

	}

    
}