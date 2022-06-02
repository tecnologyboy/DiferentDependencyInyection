namespace MvcDiferentDependencyInyection
{
    public interface IScoped
    {
        
    }

    public interface ITransient
    {
        
    }

    public interface ISingleton
    {
        
    }

    public class MyObject: ISingleton, ITransient, IScoped
    {
        //public readonly int value;

        //public MyObject()
        //{
        //    value = new Random().Next(10000);
        //}


        public readonly char value;

        public MyObject()
        {
            value = Convert.ToChar(new Random().Next(97,122));
        }
    }
}
