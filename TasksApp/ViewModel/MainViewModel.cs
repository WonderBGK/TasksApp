using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TasksApp.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		public MainViewModel() 
		{
			Items = new ObservableCollection<string>();
		}

		[ObservableProperty]
		ObservableCollection<string> items;


		// need to understand this
		[ObservableProperty]
		string text;

		// this is an interaction
		[RelayCommand]
		void Add()
		{
			if (string.IsNullOrWhiteSpace(Text))
				return;

			Items.Add(Text);
			// add our item
			Text = string.Empty;
		}

		// delete method
		[RelayCommand]
		void Delete(string item) 
		{
			if (Items.Contains(item)) 
			{  
				Items.Remove(item); 
			}
		}

	}
}
