using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace WeCantPickAGame
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            throw new System.NotImplementedException();
        }

        protected override void RegisterTypes( IContainerRegistry containerRegistry )
        {
            throw new System.NotImplementedException();
        }
    }
}
