using System;

namespace EventsAndDelegates.Classes
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending a text message " + args.Video.Title);
        }
    }
}