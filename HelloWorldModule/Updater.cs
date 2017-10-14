using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldModule
{
    public class Updater
    {
        public Updater(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        async public void Start()
        {
            await Task.Run(() => applicationRoutine());
        }

        private async void applicationRoutine()
        {
            while (true)
            {
                InfoModel infoModel = new InfoModel(indexer++);
                _eventAggregator.GetEvent<InfoChangedEvent>().Publish(infoModel);
                await Task.Delay(2000);
            }
        }

        private IEventAggregator _eventAggregator;
        private static int indexer = 0;
    }
}
