using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPS_Calc
{
    class validater
    {

        public static bool isInt(TextBox textBox)
        {
            try
            {
                Convert.ToInt16(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
