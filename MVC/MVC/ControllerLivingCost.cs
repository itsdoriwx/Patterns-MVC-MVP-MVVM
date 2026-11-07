using MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class ControllerLivingCost
    {
        public double Question(double salary, double index)
        {
            var livingCost = new LivingCost(salary, index);
            return livingCost.Cost;
        }
    }
}