using System.Threading.Tasks;

namespace FrontlineMaster.Interface.MessageQueue
{
    public interface IMessagePublisher
    {
        public Task PublishToQueue<T>(T obj);
        public Task PublishToQueue(string raw);
        public Task PublishToTopic<T>(T obj);
    }
}
