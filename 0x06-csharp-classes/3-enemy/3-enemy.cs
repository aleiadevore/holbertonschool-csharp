using System;

namespace Enemies
{
    /// <summary>This class creates a Zombie and sets its health to 0.</summary>
    public class Zombie
    {
        /// <summary>Creates private health field</summary>
        private int health;

        /// <summary>Constructs new zombie with health of 0</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Sets value of health. If value is less than 0, an error is thrown.</summary>
        public Zombie(int value)
        {
            if (value >= 0)
                health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>Gets value of Zombie health</summary> 
        public int GetHealth()
        {
            return health;
        }
    }
}
