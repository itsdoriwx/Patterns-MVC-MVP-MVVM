using System.ComponentModel;

namespace MVVM
{
    class MainVM : INotifyPropertyChanged
    {
        private double? _salary;
        private double? _index;

        public double? Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged("Cost");
            }
        }

        public double? Index
        {
            get { return _index; }
            set
            {
                _index = value;
                OnPropertyChanged("Cost");
            }
        }
        public double? Cost
        {
            get
            {
                if (Salary == null || Index == null || Index <= 0) return null;

                var livingCost = new LivingCost(Salary.Value, Index.Value);
                return livingCost.Cost;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}