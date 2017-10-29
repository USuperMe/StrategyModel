namespace 策略模式
{
    public  class CashFactory
    {
        public static CashBase CreateCashAccept(string type){
            CashBase cs=null;
            switch (type)
            {
                case "正常收费":
                cs=new CashNormal();
                break;
                case "满300返100收费":
                cs=new CashReturn(300,100);
                break;
                case "打折收费":
                cs=new CashRebate(0.8f);
                break;
                default:
                    break;
            }
            return cs;
        }
    }
}