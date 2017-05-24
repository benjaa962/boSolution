using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace boSolution.Core.ViewModel
{

	public class Bindable : INotifyPropertyChanged
	{

		#region field

		public static event PropertyChangedEventHandler StaticPropertyChanged;
		public        event PropertyChangedEventHandler       PropertyChanged;

		private Dictionary<string, object> Properties = new Dictionary<string, object>();

		#endregion

		#region protected method

		protected T Get<T> ([CallerMemberName] string propertyName = null)
		{
			object value = null;
			Properties.TryGetValue(propertyName, out value);

			if (value == null)
				return default(T);
			return (T)value;
		}
		protected void Set<T, U> (T value, [CallerMemberName] string propertyName = null)
		{
			object oldValue = Get<T>(propertyName);
			if (Equals(value, oldValue))
				return;

			Properties[propertyName] = value;
			OnStaticPropertyChanged<U>(propertyName);
		}
		protected void Set<T> (T value, [CallerMemberName] string propertyName = null)
		{
			object oldValue = Get<T>(propertyName);
			if (Equals(value, oldValue))
				return;

			Properties[propertyName] = value;
			OnPropertyChanged(propertyName);
		}

		protected static void OnStaticPropertyChanged<T> (params string[] propertyNames)
		{
			if (StaticPropertyChanged == null)
				return;

			foreach (string propertyName in propertyNames)
				StaticPropertyChanged(typeof(T), new PropertyChangedEventArgs(propertyName));
		}
		protected virtual void OnPropertyChanged (params string[] propertyNames)
		{
			if (PropertyChanged == null)
				return;

			foreach (string propertyName in propertyNames)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion

	}

}
