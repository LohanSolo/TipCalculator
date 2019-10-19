using MvvmCross;
using MvvmCross.ViewModels;
using TipCalculator.Core.Services;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
