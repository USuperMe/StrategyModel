namespace 策略模式
{
    //基类的实现
    public abstract class Strategy
    {
        public abstract void AlgoritInterface();
    }
    //策略一的实现
    public class AlgorithmA:Strategy{
        public override void AlgoritInterface(){
            System.Console.WriteLine("策略一方式的实现");
        }
    }
    //策略二的实现
    public class AlgorithmB:Strategy{
        public override void AlgoritInterface(){
            System.Console.WriteLine("策略二方式的实现");
        }
    }
    //策略三的实现
    public class AlgorithmC:Strategy{
        public override void AlgoritInterface(){
            System.Console.WriteLine("策略三方式的实现");
        }
    }
    public class Context{
        Strategy strategy;
        public Context(Strategy strategy){
            this.strategy=strategy;
        }
        public void ContextInterface(){
            strategy.AlgoritInterface();
        }
    }
    
}