using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_base
{
    public class BigSister
    {
        public void OnProductAdded(object source, EventArgs e)
        {
            Console.WriteLine("bien");
            Thread.Sleep(2000);
        }

        public void OnPayed(object source, EventArgs e)
        {
            Console.WriteLine("bien");
            Thread.Sleep(5000);
        }
    }
}
