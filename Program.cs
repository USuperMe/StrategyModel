using System;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context=new Context(new AlgorithmA());
            context.ContextInterface();
            
            context=new Context(new AlgorithmB());
            context.ContextInterface();

            context=new Context(new AlgorithmC());
            context.ContextInterface();

            // StrategyModel s=null;
            // Random random=new Random();   
            // int selectIndex=random.Next(1,5);
            // float totalPrice=100000;
            // float count=0;
            // CashBase cs=CashFactory.CreateCashAccept("打折收费");
            // //cs 在工厂中被实例化为打折收费类
            // totalPrice=cs.AcceptCash(totalPrice);
            // Console.WriteLine(totalPrice);
            
            // switch (selectIndex)
            // {
            //     //过年,一律八折
            //     case 1:
            //     totalPrice=new StrategyModel(100,200).CalculationPrice()*0.8f;
            //     break;
            //     //五一黄金周，买一送一，原则上相当于半价
            //     case 2:
            //     totalPrice=new StrategyModel(100,200).CalculationPrice()*0.5f;
            //     break;
            //     //假设买了500，满300返200
            //     case 3:
            //     totalPrice=(500-((300/500)*200));
            //     break;
            //     //买手机送   老婆
            //     case 4:
            //     Console.WriteLine("先生：你的女朋友到了，麻烦出来签收一下👩👩👩");
            //     Console.WriteLine("这个漏气了，我要退货，😭😭😭");
            //     break;
            //     default:
            //         break;
            // }
            
            
        }
    }
}
