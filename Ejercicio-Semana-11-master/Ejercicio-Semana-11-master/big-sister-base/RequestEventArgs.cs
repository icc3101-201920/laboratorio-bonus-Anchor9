using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class RequestEventArgs:EventArgs
    {
        public List<Product> cart { get; set; }
        public List<Product> shoplist { get; set; }
        public Product product { get; set; }
    }
}
