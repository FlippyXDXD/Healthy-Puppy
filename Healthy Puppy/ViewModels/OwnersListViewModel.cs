namespace Healthy_Puppy.ViewModels;

public class OwnersListViewModel : ContentPage
{
	public OwnersListViewModel()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}