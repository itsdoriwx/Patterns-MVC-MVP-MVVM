using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MVC
{
    class LivingCost
    {
        double salary;
        double index;

        public LivingCost()
        {
            salary = 30000;
            index = 1.5;
        }

        public LivingCost(double s, double i)
        {
            salary = s;
            index = i;
        }

        public double Salary { get; set; }
        public double Index { get; set; }

        public double Cost
        {
            get
            {
                if (index <= 0)
                    throw new ArgumentException("Індекс має бути більшим за 0");
                return salary / index;
            }
        }
    }
}