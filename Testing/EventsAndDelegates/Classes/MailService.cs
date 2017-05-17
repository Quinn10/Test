using System;

namespace EventsAndDelegates.Classes
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending an email " + args.Video.Title);                                     
        }
    }
}
