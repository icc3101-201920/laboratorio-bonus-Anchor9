using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_base
{
    public class BigSister
    {
        public void OnProductAdded(object source, RequestEventArgs e)
        {
            foreach (Product p in e.shoplist)
            {
                if (p.Stock <= 0)
                {
                    e.shoplist.Add(e.product);
                }
            }
        }

        public void OnPayed(object source, EventArgs e)
        {
            Console.WriteLine("bien");
            Thread.Sleep(5000);
        }
    }
}
