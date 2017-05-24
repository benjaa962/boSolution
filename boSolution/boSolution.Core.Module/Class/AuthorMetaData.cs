namespace boSolution.Core.Module
{

	public class AuthorMetaData : IAuthorMetaData
	{

		#region property

		public string Name         { get; set; }

		public string FirstName    { get; set; }
		public string LastName     { get; set; }

		public string EmailAddress { get; set; }
		public string PhoneNumber  { get; set; }

		#endregion

	}

}
