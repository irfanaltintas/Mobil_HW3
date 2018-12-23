using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private FragmentManager manager;
        private SubjectFragments subjectFragments;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button btn1 = FindViewById<Button>(Resource.Id.SendButton1);
            Button btn2 = FindViewById<Button>(Resource.Id.SendButton2);
            Button btn3 = FindViewById<Button>(Resource.Id.SendButton3);
            Button btn4 = FindViewById<Button>(Resource.Id.SendButton4);
            Button btn5 = FindViewById<Button>(Resource.Id.SendButton5);
            Button btn6 = FindViewById<Button>(Resource.Id.SendButton6);
            Button btn7 = FindViewById<Button>(Resource.Id.SendButton7);
            Button btn8 = FindViewById<Button>(Resource.Id.SendButton8);
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            manager = this.FragmentManager;
            subjectFragments = new SubjectFragments();
        }
        private void Btn_Click(object sender, System.EventArgs e)
        {
            subjectFragments.Show(manager, "Subjects");            
        }
    }
}