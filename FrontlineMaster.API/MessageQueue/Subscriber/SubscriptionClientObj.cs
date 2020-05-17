using Microsoft.Azure.ServiceBus;

namespace FrontlineMaster.API.MessageQueue.Subscriber
{
    public class SubscriptionClientObj
    {

        public ISubscriptionClient GetSubscriptionClient(string subscriptionName)
        {
            if (subscriptionName == SubscriptionDetails.OrderSubscription)
            {
                return new SubscriptionClient(SubscriptionDetails.ConnectionString, SubscriptionDetails.TopicName, SubscriptionDetails.OrderSubscription);
            }
            else if (subscriptionName == SubscriptionDetails.CustomerSubscription)
            {
                return new SubscriptionClient(SubscriptionDetails.ConnectionString, SubscriptionDetails.TopicName, SubscriptionDetails.CustomerSubscription);
            }
            return null;
        }
    }
}
