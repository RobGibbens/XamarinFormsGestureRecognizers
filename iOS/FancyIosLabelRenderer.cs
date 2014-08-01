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
		UILongPressGestureRecognizer longPressGestureRecognizer;
		UITapGestureRecognizer tapGestureRecognizer;
		UIPinchGestureRecognizer pinchGestureRecognizer;
		UIPanGestureRecognizer panGestureRecognizer;
		UISwipeGestureRecognizer swipeGestureRecognizer;
		UIRotationGestureRecognizer rotationGestureRecognizer;

		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			longPressGestureRecognizer = new UILongPressGestureRecognizer (() => Console.WriteLine ("Long Press"));
			tapGestureRecognizer = new UITapGestureRecognizer (() => Console.WriteLine ("Tap"));
			pinchGestureRecognizer = new UIPinchGestureRecognizer (() => Console.WriteLine ("Pinch"));
			panGestureRecognizer = new UIPanGestureRecognizer (() => Console.WriteLine ("Pan"));
			swipeGestureRecognizer = new UISwipeGestureRecognizer (() => Console.WriteLine ("Swipe"));
			rotationGestureRecognizer = new UIRotationGestureRecognizer (() => Console.WriteLine ("Rotation"));

			if (e.NewElement == null) {
				if (longPressGestureRecognizer != null) {
					this.RemoveGestureRecognizer (longPressGestureRecognizer);
				}
				if (tapGestureRecognizer != null) {
					this.RemoveGestureRecognizer (tapGestureRecognizer);
				}
				if (pinchGestureRecognizer != null) {
					this.RemoveGestureRecognizer (pinchGestureRecognizer);
				}
				if (panGestureRecognizer != null) {
					this.RemoveGestureRecognizer (panGestureRecognizer);
				}
				if (swipeGestureRecognizer != null) {
					this.RemoveGestureRecognizer (swipeGestureRecognizer);
				}
				if (rotationGestureRecognizer != null) {
					this.RemoveGestureRecognizer (rotationGestureRecognizer);
				}
			}

			if (e.OldElement == null) {
				this.AddGestureRecognizer (longPressGestureRecognizer);
				this.AddGestureRecognizer (tapGestureRecognizer);
				this.AddGestureRecognizer (pinchGestureRecognizer);
				this.AddGestureRecognizer (panGestureRecognizer);

				this.AddGestureRecognizer (swipeGestureRecognizer);
				this.AddGestureRecognizer (rotationGestureRecognizer);
			}
		}
	}
}