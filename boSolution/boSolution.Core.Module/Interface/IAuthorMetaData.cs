namespace boSolution.Core.Module
{

	public interface IAuthorMetaData
	{

		string Name         { get; }

		string FirstName    { get; }
		string LastName     { get; }

		string EmailAddress { get; }
		string PhoneNumber  { get; }

	}

}
