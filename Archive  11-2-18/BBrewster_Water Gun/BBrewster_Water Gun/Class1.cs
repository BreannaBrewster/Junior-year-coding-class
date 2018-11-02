using System;
using System.Collections.Generic;
using System.Text;

namespace BBrewster_Water_Gun
{
    class WaterGun
    {
        public float compasity;
        public bool isWet;
        //public Random rand = new Random();
        public bool shoot(float amount)
        {
            float compasity = 1;
            Random rand = new Random();
            if (compasity > 0)
            {
                compasity -= amount;
                float percentChance = (amount * .2f) + .2f;
                if (rand.NextDouble() == percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

}
