using StockShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShop.Classes
{
    internal class ConnectDB
    {
        public static ZdorzhyievSwebContext connect = new ZdorzhyievSwebContext();
    }
}
