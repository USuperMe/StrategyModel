namespace 策略模式
{
    public class CashNormal:CashBase
    {
        public override float AcceptCash(float money){
            return money;
        }
    }
}