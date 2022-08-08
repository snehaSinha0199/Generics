namespace NamedParameter
{
   public class Arithmetic { 
        
            public static int Add(int a, int b = 10)
            {
                return a + b;
            }

            public static int Divide(int a, int b = 1)
            {
                return a / b;
            }

            public static int CustomMethod(int number, string name = "GL")
            {
                return 0;
            }
        }
    }
