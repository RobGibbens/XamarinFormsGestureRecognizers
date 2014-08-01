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

			if (this.Control != null) {
				this.Control.GenericMotion += (sender, genericMotionEventArgs) => _detector.OnTouchEvent (genericMotionEventArgs.Event);
				this.Control.Touch += (sender, touchEventArgs) => _detector.OnTouchEvent (touchEventArgs.Event);
			}
		}
	}
}