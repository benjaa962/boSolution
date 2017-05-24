using System;

namespace boSolution.Core.Article
{

	public interface IArticle
	{

		Uri Uri { get; }

		string GetName(ArticleNameType type);

	}

}
