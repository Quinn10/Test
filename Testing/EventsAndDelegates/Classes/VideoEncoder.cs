using System;
using System.Threading;

namespace EventsAndDelegates.Classes
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;

        /// <summary>
        /// Encoding will happen here
        /// </summary>
        /// <param name="video"></param>
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video started..." + video.Title);
            OnVideoEncoded(video);

            Console.WriteLine("Encoding video completed..." + video.Title);
        }

        /// <summary>
        /// Better standard to make event method protected and virtual
        /// </summary>
        protected virtual void OnVideoEncoded(Video video)
        {
            // check if there are any subscribers and then invoke them.
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
