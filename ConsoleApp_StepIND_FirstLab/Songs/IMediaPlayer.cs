namespace ConsoleApp_StepIND_FirstLab.Songs
{
    internal interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void Next();
        void Previous();
        public int Volume { get; set; }
    }
}
