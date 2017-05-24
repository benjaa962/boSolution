namespace boSolution.Core.Article
{

	public class ArticleSize
	{

		#region constructor

		public ArticleSize (long sizeInBytes)
		{
			SizeInBytes = sizeInBytes;
		}

		#endregion

		#region property

		public long SizeInBytes { get; }

		#endregion

		#region public method

		public double SizeInPercent (long totalSizeInBytes)
		{
			throw new System.NotImplementedException();
		}
		public double SizeInPercent (ArticleSize totalSize)
		{
			var totalSizeInBytes = totalSize ?. SizeInBytes ?? 0;
			return SizeInPercent(totalSizeInBytes);
		}

		#endregion

	}

}
