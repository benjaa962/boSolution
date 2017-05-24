namespace boSolution.Core.Module
{

	public interface IAuthorInfo
	{

		string Name         { get; }
		string FirstName    { get; }
		string LastName     { get; }

		string EmailAddress { get; }
		string PhoneNumber  { get; }

	}

}
