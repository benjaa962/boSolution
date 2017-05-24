namespace boSolution.Core.Module
{

	public interface IModuleMetaData
	{

		string          Version        { get; }
		IAuthorMetaData AuthorMetaData { get; }

	}

}
