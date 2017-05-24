using System;
using System.Collections.Generic;

namespace boSolution.Core.Article
{

	public interface IParentArticle : IArticle
	{

		IEnumerable<string  > GetChildrenPaths   ();
		IEnumerable<Uri     > GetChildrenUris    ();
		IEnumerable<IArticle> GetChildrenArticles();

	}

}
