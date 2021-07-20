using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Task
{
    class ButtonModel : Button
    {
        public int Number { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
