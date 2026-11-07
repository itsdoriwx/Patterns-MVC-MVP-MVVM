using System;

namespace MVVM
{
    class LivingCost
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

        public double Salary
        {
            get; set;
        }

        public double Index
        {
            get; set;
        }

        public double Cost
        {
            get
            {
                if (index <= 0) return 0;
                return salary / index;
            }
        }
    }
}