using System;

namespace DartsLib
{
    public class Dart
    {
        Random _randomGenerator;

        public Dart(Random randomGenerator)
        {
            this._randomGenerator = randomGenerator;
        }

        public void Throw(out string valueHit, out bool doubleRing, out bool tripleRing)
        {
            //Randomly select value from 0 to 21. 0 = Bullseye inner ring, 21 = Bullseye outer ring
            int hitSection = _randomGenerator.Next(23);
            if (hitSection == 0)
            {
                valueHit = "InnerBullseye";
            }
            else if (hitSection == 21)
            {
                valueHit = "OuterBullseye";
            }
            else if (hitSection == 22)
            {
                valueHit = "Miss";
            }
            else
            {
                valueHit = hitSection.ToString();
            }

            //Randomly selects if double or triple ring is hit.
            int multiplierHit = _randomGenerator.Next(1, 101);
            if (multiplierHit >= 95)
            {
                doubleRing = false;
                tripleRing = true;
            }
            else if (multiplierHit >= 85 && multiplierHit < 95)
            {
                doubleRing = true;
                tripleRing = false;
            }
            else
            {
                doubleRing = false;
                tripleRing = false;
            }

        }
    }
}
