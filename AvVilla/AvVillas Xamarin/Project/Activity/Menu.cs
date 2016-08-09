
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project
{
	[Activity(Label = "Menu")]
	public class Menu : Activity
	{
		ImageButton Consulta;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Menu);

			Consulta = FindViewById<ImageButton>(Resource.Id.Consulta);

			Consulta.Click += Consulta_Click;

			// Create your application here
		}
		void Consulta_Click(object sender, EventArgs e)
		{
			StartActivity(new Intent(Application.Context, typeof(MainActivity)));
			OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
			Finish();
		}


	}
}

