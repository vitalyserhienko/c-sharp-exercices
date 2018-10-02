namespace Polymorphism
{
    public class MailMitificationChannel : INotificationChannel
    {
        void INotificationChannel.Send(Messsage message)
        {
            System.Console.WriteLine("Sending mail...");
        }
    }
}
