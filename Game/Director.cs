namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Hider hider = new Hider();
        private bool isPlaying = true;
        private Seeker seeker = new Seeker();
        private IOService ioService = new IOService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            ioService.WriteText(hider.location.ToString());
            int location = ioService.ReadNumber("\nEnter a location [1-1000]: ");
            seeker.MoveLocation(location);
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            hider.WatchSeeker(seeker);
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            string hint = hider.GetHint();
            ioService.WriteText(hint);
            if (hider.IsFound())
            {
                isPlaying = false;
            }
            
        }
    }
}