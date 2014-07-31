using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;
using System;
using XamarinFormsGestureRecognizers;
using XamarinFormsGestureRecognizers.iOS;

[assembly: ExportRenderer (typeof(FancyLabel), typeof(FancyIosLabelRenderer))]

namespace XamarinFormsGestureRecognizers.iOS
{
	public class FancyIosLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			if (this.Control != null) {
				this.Control.UserInteractionEnabled = true;
				this.Control.MultipleTouchEnabled = true;

				this.Control.AddGestureRecognizer (new UILongPressGestureRecognizer (() => Console.WriteLine ("Long Press")));
				this.Control.AddGestureRecognizer(new UITapGestureRecognizer(() => Console.WriteLine ("Tap")));
				this.Control.AddGestureRecognizer(new UIPinchGestureRecognizer(() => Console.WriteLine ("Pinch")));
				this.Control.AddGestureRecognizer(new UIPanGestureRecognizer(() => Console.WriteLine ("Pan")));
				this.Control.AddGestureRecognizer(new UISwipeGestureRecognizer(() => Console.WriteLine ("Swipe")));
				this.Control.AddGestureRecognizer(new UIRotationGestureRecognizer(() => Console.WriteLine ("Rotation")));
			}
		}
	}
}