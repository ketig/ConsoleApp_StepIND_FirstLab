using System.Collections;

namespace ConsoleApp_StepIND_FirstLab.Songs
{
    internal class AudioPlayer : IMediaPlayer, IEnumerable<Song>
    {
        public void Play()
        {
            Console.WriteLine(_playList[_index]);
        }

        public void Pause()
        {
            Console.WriteLine("AudioPlayer paused!");
        }

        public void Stop()
        {
            Console.WriteLine("AudioPlayer stopped!");
        }

        public void Next()
        {
            Console.WriteLine("AudioPlayer next track!");
        }
        public void Previous()
        {
            Console.WriteLine("AudioPlayer previous track!");
        }

        private int _volume;

        /// <summary>
        /// Gets or sets the volume of the audio player.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Volume must be between 0 and 100.</exception>
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Volume must be between 0 and 100.");
                }
                else
                {
                    _volume = value;
                }
            }
        }

        private List<Song> _playList;
        private int _index;

        public AudioPlayer()
        {
            _index = -1;
            _playList = new List<Song>();
        }

        public AudioPlayer(List<Song> playList)
        {
            _index = 0;
            _playList = playList;
        }

        public void AddSong(Song song)
        {
            _playList.Add(song);
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return _playList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
