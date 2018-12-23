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

namespace App3
{
    class SubjectFragments : DialogFragment
    {
        private ListView list;
        private String[] subjects = { "Mentoring", "Course Information", "Thesis", "Project", "General" };
        ArrayAdapter adapter;
        
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Subject, container, false);
            View view2 = inflater.Inflate(Resource.Layout.activity_main, container, false);
            this.Dialog.SetTitle("Subjects");
            list = view.FindViewById<ListView>(Resource.Id.myList);
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, subjects);
            list.Adapter = adapter;
            var email1 = view2.FindViewById<TextView>(Resource.Id.Mail1);
            var email2 = view2.FindViewById<TextView>(Resource.Id.Mail2);
            var email3 = view2.FindViewById<TextView>(Resource.Id.Mail3);
            var email4 = view2.FindViewById<TextView>(Resource.Id.Mail4);
            var email5 = view2.FindViewById<TextView>(Resource.Id.Mail5);
            var email6 = view2.FindViewById<TextView>(Resource.Id.Mail6);
            var email7 = view2.FindViewById<TextView>(Resource.Id.Mail7);
            var email8 = view2.FindViewById<TextView>(Resource.Id.Mail8);

            String[] emails = {email1.Text,email2.Text,email3.Text,email4.Text,email5.Text,email6.Text,email7.Text,email8.Text };

            list.ItemClick += (s, e) => {
                Intent nextActivity = new Intent(Context, Java.Lang.Class.FromType(typeof(Mail_Page)));
                nextActivity.PutExtra("email", emails[e.Position]);
                nextActivity.PutExtra("subject", subjects[e.Position]);
                StartActivity(nextActivity);
            };
            return view;
        }

    }
}