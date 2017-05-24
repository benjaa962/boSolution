using System;
using System.ComponentModel.Composition;

namespace boSolution.Core.Module
{

	[MetadataAttribute]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ModuleAttribute : ExportAttribute
	{

		#region constructor

		public ModuleAttribute (string key) : base(typeof(IModule)) => Key = key;

		#endregion

		#region property

		public string Key { get; }

		#endregion

	}

}
