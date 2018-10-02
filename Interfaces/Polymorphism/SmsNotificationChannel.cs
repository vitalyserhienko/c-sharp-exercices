namespace Polymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        void INotificationChannel.Send(Messsage message)
        {
            System.Console.WriteLine("Sending sms...");
        }
    }
}
