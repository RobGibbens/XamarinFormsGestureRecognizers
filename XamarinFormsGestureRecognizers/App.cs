using Xamarin.Forms;

namespace XamarinFormsGestureRecognizers
{
	public static class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new FancyLabel {
					Text = "Hello, Forms!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}