namespace TasksApp
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			// now we add the routing to the new page we created
			Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));

		}
	}
}
