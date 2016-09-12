using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.Widget;

namespace RecyclerPractice
{
    //  ConfigChanges to avoid reloading the page when changing the orientation
    [Activity(Label = "RecyclerPractice", MainLauncher = true, Icon = "@drawable/icon",
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.KeyboardHidden)]
    public class MainActivity : Activity
    {
        private RecyclerView recyclerView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
            recyclerView.SetAdapter(new QuestionAdapter(SampleData.GetQuestions(), this));
        }
    }
}