namespace QueueGeneric
{
    public interface IGeneric<T>
    {
        public T check(T value);
    }
    public class Class1<T, V> where T : struct where V : struct
    {
        public T check(T value1, V value2)
        {
            return value1;
        }
    }
        

    }
