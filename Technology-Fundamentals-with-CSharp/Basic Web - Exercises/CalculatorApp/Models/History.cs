using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    public class History
    {
        public static List<Calculator> CalculationsHistory { get; set; } = new List<Calculator>();
    }
}
