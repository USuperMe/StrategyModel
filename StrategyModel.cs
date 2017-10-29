namespace 策略模式
{
    public class StrategyModel
    {
        public float unitPrice { get; set; }
        public float count { get; set; }
        public StrategyModel(float unitPrice, float count)
        {
            this.unitPrice = unitPrice;
            this.count = count;
        }
        public float CalculationPrice()
        {
            return (unitPrice * count);
        }
    }
}