
using Android.App;
using Android.OS;
using FinalWorkshop.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace FinalWorkshop.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticView : MvxActivity<LogicViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.QuadraticPage);
        }
    }
}