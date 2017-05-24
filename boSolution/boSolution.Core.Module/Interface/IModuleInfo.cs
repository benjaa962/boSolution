using System;

namespace boSolution.Core.Module
{

	public interface IModuleInfo
	{

		Version Version { get; }

		string Label       { get; }
		string Description { get; }

		IAuthorInfo AuthorInfo { get; }

	}

}
