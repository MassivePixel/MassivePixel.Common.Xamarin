using GalaSoft.MvvmLight.Ioc;
using Xamarin.Forms;

namespace MassivePixel.Common.Xamarin.Mvvm
{
    public class NavigateCommand<TPage> : Command
        where TPage : Page, new()
    {
        public NavigateCommand()
            : base(Navigate)
        {
        }

        private static void Navigate()
        {
            var ns = SimpleIoc.Default.GetInstance<INavigation>();
            ns.PushAsync(new TPage());
        }
    }
}
