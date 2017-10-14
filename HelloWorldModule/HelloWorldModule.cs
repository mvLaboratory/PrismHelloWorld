using System;
using Prism.Modularity;
using Prism.Regions;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        private readonly IRegionManager regionManager;
        private Updater _updater;

        public HelloWorldModule(IRegionManager regionManager, Updater updater)
        {
            this.regionManager = regionManager;
            _updater = updater;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorldView));
            _updater.Start();
        }
    }
}
