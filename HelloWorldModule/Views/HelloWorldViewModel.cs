using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldModule.Views
{
    public class HelloWorldViewModel : BaseViewModel
    {
        public String TestText { get; set; }

        private IEventAggregator eventAggregator;
        private SubscriptionToken subscriptionToken;

        public HelloWorldViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            InfoChangedEvent infoEvent = eventAggregator.GetEvent<InfoChangedEvent>();
            if (subscriptionToken != null)
            {
                infoEvent.Unsubscribe(subscriptionToken);
            }
            subscriptionToken = infoEvent.Subscribe(InfoChangedEventHandler, ThreadOption.UIThread, false, InfoFilter);

        }

        public bool InfoFilter(InfoModel infoModel)
        {
            return true;
        }

        public void InfoChangedEventHandler(InfoModel model)
        {
            TestText = model.Text;
        }
    }
}
