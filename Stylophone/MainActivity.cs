using System;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace Stylophone
{
	[Activity (Label = "Stylophone", MainLauncher = true,ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]

	public class MainActivity : Activity
	{
		int sr = 44100;
		bool isRunning=true;
		double freq;
		Thread t1;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			Button a2 = FindViewById<Button> (Resource.Id.a2);
			Button b2 = FindViewById<Button> (Resource.Id.b2);
			Button c3 = FindViewById<Button> (Resource.Id.c3);
			Button d3 = FindViewById<Button> (Resource.Id.d3);
			Button e3 = FindViewById<Button> (Resource.Id.e3);
			Button f3 = FindViewById<Button> (Resource.Id.f3);
			Button g3 = FindViewById<Button> (Resource.Id.g3);
			Button a3 = FindViewById<Button> (Resource.Id.a3);
			Button b3 = FindViewById<Button> (Resource.Id.b3);
			Button c4 = FindViewById<Button> (Resource.Id.c4);
			Button d4 = FindViewById<Button> (Resource.Id.d4);
			Button e4 = FindViewById<Button> (Resource.Id.e4);
			Button a2s = FindViewById<Button> (Resource.Id.a2s);
			Button c3s = FindViewById<Button> (Resource.Id.c3s);
			Button d3s = FindViewById<Button> (Resource.Id.d3s);
			Button f3s = FindViewById<Button> (Resource.Id.f3s);
			Button g3s = FindViewById<Button> (Resource.Id.g3s);
			Button a3s = FindViewById<Button> (Resource.Id.a3s);
			Button c4s = FindViewById<Button> (Resource.Id.c4s);
			Button d4s = FindViewById<Button> (Resource.Id.d4s);
			//RequestWindowFeature(WindowFeatures.NoTitle);
			//Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);
			t1 = new Thread (PlaySynth);
			t1.Start ();
			freq = 0;
			a2.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=110;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;

			};
			a2s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=116.541;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			b2.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=123.471;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			c3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=130.813;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			c3s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=138.591;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			d3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=146.832;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			d3s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=155.563;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			e3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=164.814;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			f3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=174.614;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			f3s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=184.997;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			g3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=195.998;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			g3s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=201.652;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			a3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=220;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			a3s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=233.082;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			b3.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=246.942;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;

			};
			c4.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=261.626;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			c4s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=261.626;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			d4.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=293.665;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			d4s.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=311.127;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};
			e4.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Down)
					freq=329.628;
				if (args.Event.Action == MotionEventActions.Up && args.Event.PointerCount>=1)
					freq=0;
			};

		}
		protected override void OnDestroy()
		{
			base.OnDestroy ();
			isRunning = false;
			t1.Join ();

		}
		public void PlaySynth()
		{
			int buffsize = 1024;
			//int buffsize = AudioTrack.GetMinBufferSize (sr,ChannelOut.Mono, Android.Media.Encoding.Pcm16bit);
			AudioTrack atrack = new AudioTrack (Stream.Music, sr, ChannelConfiguration.Mono, Android.Media.Encoding.Pcm16bit, buffsize, AudioTrackMode.Stream);	
			short[] samples = new short[buffsize];
			int amp = 10000;
			double twopi = 8*Math.Atan (1.0);
			double ph = 0.0;
			atrack.Play ();
			while (isRunning) {
				for (int i = 0; i < buffsize; i++) {
					samples [i] = (short)(amp * squarewave(ph));
					ph += twopi * freq / sr;

				}
				atrack.Write (samples, 0, buffsize);

			}
			atrack.Stop ();
			atrack.Release ();
		}
		public double squarewave(double ph)
		{
			if (Math.Sin (ph) > 0)
				return 1.0;
			else
				return -1.0;
		}
	}

}


