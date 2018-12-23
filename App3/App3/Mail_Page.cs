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
    [Activity(Label = "Mail_Page")]
    public class Mail_Page : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MailPageView);
            string email = Intent.GetStringExtra("email" ?? "Not Recv");
            string subject_topic = Intent.GetStringExtra("subject" ?? "Not Recv");

            var address = FindViewById<EditText>(Resource.Id.editText1);
            var subject = FindViewById<EditText>(Resource.Id.editText2);
            address.Text = email;
            subject.Text = subject_topic;

        }
    }
}