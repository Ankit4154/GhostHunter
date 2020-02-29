using System;

namespace GhostHunter
{
    // class definition
    public class Player
    {
        // private and internal access specifier for member variables
        // for having limited access to only current containing type Class
        //  & current assembly Classes
        private int bulletPosition;
        private int spinValue;
        internal int totalScore;
        internal int totalWins;
        internal int totalLoses;
        internal int chance;


        // constructor for initializing default values
        public Player()
        {
            bulletPosition = -1;
            spinValue = -2;
            chance = 2;
            totalScore = 0;
            totalWins = 0;
            totalLoses = 0;
        }

        // Re-initializes chance with 2 for game reset events.
        // Assigns random number between 0-5 to bulletPosition.
        // Param - random, integer number from 0-5.
        // Return - Boolean, true if number is between 0 or 5; else false.
        public Boolean LoadBullets(int random)
        {
            chance = 2;
            if (random < 0 || random > 5)
                return false;
            bulletPosition = random;
            return true;
        }

        // Assigns random number between 0-5 to spinValue.
        // Param - random, integer number from 0-5.
        // Return - Boolean, true if number is between 0 or 5; else false.
        public Boolean SpinChambers(int random)
        {
            if (random < 0 || random > 5)
                return false;
            spinValue = random;
            return true;
        }
        // Checks the spinValue and bulletPosition values.
        // If found equal, increments win points by 1,
        // total score by 10, assigns specific check value -3 to chance.
        // Else decrement chance by 1, and if no chance left(0)
        // increments lose points by 1.
        public void Fire()
        {
            if (spinValue == bulletPosition)
            {
                totalWins++;
                totalScore += 10;
                chance = -3;
            }
            else
            {
                chance--;
                if (chance == 0)
                    totalLoses++;
            }
        }
    }
}

