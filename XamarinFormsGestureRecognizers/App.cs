using Xamarin.Forms;
using System;

namespace XamarinFormsGestureRecognizers
{
	public static class App
	{
		public static Page GetMainPage ()
		{	
			var fancyLabel = new FancyLabel {
				Text = "Hello, Forms!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			var tapGestureRecognizer = new TapGestureRecognizer ();
			tapGestureRecognizer.Tapped += (sender, e) => Console.WriteLine ("Tapped");
			fancyLabel.GestureRecognizers.Add (tapGestureRecognizer);

			return new ContentPage { 
				Content = fancyLabel
			};
		}
	}
}