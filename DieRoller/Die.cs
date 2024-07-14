namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6)
    /// </summary>
    public class Die
    {
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// Create the die and rolls it to set the initial face value
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool isHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>
        /// to a new number if the die is not currently held.
        /// Returns the <see cref="FaceValue"/>
        /// </summary>
        /// <returns>Returns the <see cref="FaceValue"/></returns>
        public byte Roll()
        {
            if (!isHeld)
            {
                // Generate random number
                byte newValue = (byte)_random.Next(1, 7);

                FaceValue = newValue;
            }

            return FaceValue;
        }
    }
}
