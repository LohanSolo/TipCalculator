using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.Views
{
    [Activity(Label = "Tip Calculator", MainLauncher = true)]
    public class TipView : MvxActivity<TipViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TipCalculatorView);
        }
    }
}