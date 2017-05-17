using System;
using EventsAndDelegates.Classes;

namespace EventsAndDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService();

            //subscribe to the publisher
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            //unsubscribe to the publisher
            videoEncoder.VideoEncoded -= mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded -= messageService.OnVideoEncoded;
            Console.ReadLine();
        }
    }
}
