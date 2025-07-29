namespace ConsoleApp_StepIND_FirstLab
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
