namespace MVP
{
    class LivingCostPresenter
    {
        private readonly ILivingCostView view;
        private readonly ILivingCostModel model;

        public LivingCostPresenter(ILivingCostView view, ILivingCostModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadLivingCost(double salary, double index)
        {
            var livingCost = new LivingCost(salary, index);
            view.SetCost(livingCost.Cost());
        }
    }
}