using System.ComponentModel;

namespace TasksApp.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{

		// need to understand this
		string text;

		public string Text
		{
			get => text;
			set
			{
				text = value;
				OnPropertyChange(nameof(Text));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		void OnPropertyChange(string name) => 
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
