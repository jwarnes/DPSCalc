using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPS_Calc
{
    class dpscalc
    {
        public static int calculateNecessaryDPS(int bossHP, int numDPS, decimal tankDPS, int enrage, float debuff)
        {
            float necessaryDPS;

            //adjust the total health pool by the debuff
            bossHP = (int)((float)bossHP*(1.0f - debuff));

            //determine the amount of damage per second needed to defeat the boss before the enrage timer
            float raidDPS = bossHP / enrage;

            //subtract estimated tank contribution
            raidDPS -= (float)tankDPS;

            //divide the remaining health pool/second by the number of DPS players and return
            necessaryDPS = raidDPS / numDPS;
            return (int)necessaryDPS;
        }


    }
}
