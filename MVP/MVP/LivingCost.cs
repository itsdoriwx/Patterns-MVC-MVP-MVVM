using System;

namespace MVP
{
    class LivingCost : ILivingCostModel
    {
        double salary;
        double index;

        public LivingCost(double s, double i)
        {
            salary = s;
            index = i;
        }

        public LivingCost()
        {
            salary = 30000;
            index = 1.5;
        }

        public double Cost()
        {
            if (index <= 0) throw new ArgumentException("Індекс має бути більшим за 0");
            return salary / index;
        }
    }
}