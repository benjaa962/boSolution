namespace boSolution.Core.Module
{

	public class ModuleMetaData : IModuleMetaData
	{

		#region property

		public string Version { get; set; }

		public IAuthorMetaData AuthorMetaData { get; } = new AuthorMetaData();

		#endregion

	}

}
