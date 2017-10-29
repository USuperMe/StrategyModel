namespace 策略模式
{
    public class CashReturn:CashBase
    {
        private float moneyCondition=0;
        private float moneyReturn=0;
        public CashReturn(float moneyCondition,float moneyReturn){
            this.moneyCondition=moneyCondition;
            this.moneyReturn=moneyReturn;
        }
        public override float AcceptCash(float money){
            float result=money;
            if (money>=moneyCondition){
                return money-(moneyCondition/money)*moneyReturn;
            }
            return money;
        }
    }
}