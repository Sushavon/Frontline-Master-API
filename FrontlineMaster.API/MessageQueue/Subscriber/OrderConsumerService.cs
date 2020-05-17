using FrontlineMaster.Entity.MessageQueueModels;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrontlineMaster.API.MessageQueue.Subscriber
{
    public class OrderConsumerService : BackgroundService
    {

        private readonly ISubscriptionClient _subscriptionClient;

        public OrderConsumerService()
        {
            _subscriptionClient = new SubscriptionClientObj().GetSubscriptionClient(SubscriptionDetails.OrderSubscription);
        }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _subscriptionClient.RegisterMessageHandler((message, token) =>
            {
                var order = JsonConvert.DeserializeObject<Order>(Encoding.UTF8.GetString(message.Body));
                Debug.WriteLine(order);
                return _subscriptionClient.CompleteAsync(message.SystemProperties.LockToken);
            }, new MessageHandlerOptions(args => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });
            await Task.CompletedTask;
        }
    }
}
