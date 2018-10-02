using System.Collections.Generic;

namespace Polymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic

            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Messsage());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channnel)
        {
            _notificationChannels.Add(channnel);
        }
    }
}
