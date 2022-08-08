namespace Generics
{
   

    public class Student
    {
      
     public int Id { get; set; }
      public string Name { get; set; }

        public Student() { }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    
    public class Gen1<T, V>
    {
        public T Id { get; set; }
       public V studentName { get; set; }
        public Gen1(T tobj,V vobj)
        {
            this.Id = tobj;
            this.studentName = vobj;
        }

        public void TType()
        {
            Console.WriteLine(Id.GetType().ToString());
        }
        public void VType()
        {
            Console.WriteLine(studentName.GetType().ToString());
        }
    }
    public class People
    {
        public int age { get; set; }
       
       
    }
    public class Vote<T,V> where T :class where V :struct 
    {
       
        public void eligibility(V v) {
            if (v.Equals(18))
            {
                Console.WriteLine("eligible");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
            }
        }
    public class Gen3<T> where T : Student
    {
        public Gen3()
        {
            Console.WriteLine("Gen3 Generic Class Constructor");
        }
        public void add(T t1,T t2)
        {
            t1.Id = t2.Id;
        }
    }
    }
