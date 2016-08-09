using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Project
{
    public class DatePickerFragment : Fragment, Android.App.DatePickerDialog.IOnDateSetListener
    {
		public static string dateString;
		public static DateTime date;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.DatePicker, container, false);

            view.FindViewById<Button>(Resource.Id.btnCalendario).Click += (sender, args) =>
            {
                var dialog = new DatePickerDialog(Activity, DateTime.Now, this);
                dialog.Show(FragmentManager, null);
            };
            return view;
        }

        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            date = new DateTime(year, monthOfYear + 1, dayOfMonth);
			dateString = date.ToString("yyyy-MM-dd");
			View.FindViewById<TextView>(Resource.Id.FechaInicial).Text = dateString;
        }
    }
}