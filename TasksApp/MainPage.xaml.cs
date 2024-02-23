using TasksApp.ViewModel;

namespace TasksApp
{
	public partial class MainPage : ContentPage
	{

		public MainPage(MainViewModel vm)
		{
			InitializeComponent();
			// added MainViewModel as an argument 
			// set BindingContext to vm    
			BindingContext = vm;
		}

		
	}

}
