using System;

namespace boSolution.Core.Article
{

	public interface IArticle
	{

		Uri Uri { get; }

		string      GetName (ArticleNameType type);
		DateTime    GetDate (ArticleDateType type);
		ArticleSize GetSize (ArticleSizeType type);

	}

}
