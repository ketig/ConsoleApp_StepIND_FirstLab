using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_StepIND_FirstLab.LINQ
{
    internal class Order
    {
        public int PersonId { get; set; }
        public int ProductId { get; set; }

        public override string ToString()
        {
            return $"PersonId: {PersonId}, ProductId: {ProductId}.";
        }
    }
}
