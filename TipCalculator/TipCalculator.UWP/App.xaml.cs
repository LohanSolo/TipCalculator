using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace TipCalculator.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class TipCalculatorApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}