﻿using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using Gemini.Framework;
using Gemini.Framework.Results;
using Gemini.Modules.MainMenu.Models;

namespace Gemini.Modules.Inspector
{
	[Export(typeof(IModule))]
	public class Module : ModuleBase
	{
		public override void Initialize()
		{
            if (MainMenu.All.FirstOrDefault(x => x.Name == "View") != null)
            {
			    MainMenu.All.First(x => x.Name == "View")
				    .Add(new MenuItem("Inspector", OpenInspector));
            }
		}

		private static IEnumerable<IResult> OpenInspector()
		{
			yield return Show.Tool<IInspectorTool>();
		}
	}
}