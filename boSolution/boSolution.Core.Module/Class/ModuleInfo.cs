using System;

namespace boSolution.Core.Module
{

	public class ModuleInfo : IModuleInfo
	{

		#region property

		public Version Version { get; set; }

		public string Label       { get; set; }
		public string Description { get; set; }

		public IAuthorInfo AuthorInfo { get; }

		#endregion

	}

}
