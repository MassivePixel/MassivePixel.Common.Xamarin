using GalaSoft.MvvmLight.Ioc;
using Xamarin.Forms;

namespace MassivePixel.Common.Xamarin.Mvvm
{
    public class NavigateCommand<TPage> : Command
        where TPage : Page, new()
    {
        public NavigateCommand()
            : base(() => Navigate())
        {
        }

        public NavigateCommand(object bindingContext)
            : base(() => Navigate(bindingContext))
        {
        }

        private static async void Navigate(object bindingContext)
        {
            var ns = SimpleIoc.Default.GetInstance<INavigation>();
            await ns.PushAsync(new TPage
            {
                BindingContext = bindingContext
            });
        }

        private static async void Navigate()
        {
            var ns = SimpleIoc.Default.GetInstance<INavigation>();
            await ns.PushAsync(new TPage());
        }
    }
}
