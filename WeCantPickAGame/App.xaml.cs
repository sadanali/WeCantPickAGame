﻿using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using WeCantPickAGame.Views;

namespace WeCantPickAGame
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes( IContainerRegistry containerRegistry )
        {
        }
    }
}
