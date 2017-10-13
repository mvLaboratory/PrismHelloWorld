using System;
using Prism.Modularity;
using Prism.Regions;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        private readonly IRegionManager regionManager;

        public HelloWorldModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorldView));

            new Updater().Start();
        }
    }
}
