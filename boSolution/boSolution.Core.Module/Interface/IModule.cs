namespace boSolution.Core.Module
{

	public interface IModule
	{

		string      Key  { get; }
		IModuleInfo Info { get; }

		ModuleState GetState ();

	}

}
