using System;

public class class1
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
