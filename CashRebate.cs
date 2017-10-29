namespace 策略模式
{
    public class CashRebate:CashBase
    {
        public float moneyRebate { get; set; }
        
        public CashRebate(float moneyRebate){
            this.moneyRebate=moneyRebate;
        }
        public override float AcceptCash(float money){
            return money*moneyRebate;
        }

    }
}