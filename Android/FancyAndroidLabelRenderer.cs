using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XamarinFormsGestureRecognizers;
using XamarinFormsGestureRecognizers.Droid;
using Android.Views;

[assembly: ExportRenderer (typeof(FancyLabel), typeof(FancyAndroidLabelRenderer))]

namespace XamarinFormsGestureRecognizers.Droid
{
	public class FancyAndroidLabelRenderer : LabelRenderer
	{
		private readonly FancyGestureListener _listener;
		private readonly GestureDetector _detector;

		public FancyAndroidLabelRenderer ()
		{
			_listener = new FancyGestureListener ();
			_detector = new GestureDetector (_listener);

		}

		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}

			if (e.OldElement == null) {
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}

		void HandleTouch (object sender, TouchEventArgs e)
		{
			_detector.OnTouchEvent (e.Event);
		}

		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			_detector.OnTouchEvent (e.Event);
		}
	}
}