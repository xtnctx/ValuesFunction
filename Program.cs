

/* Exercise from https://www.exercisescsharp.com/arithmetic/calculate-values-function */

namespace ValuesFunction
{

    public class QuadraticFunction
    {
        static void Main()
        {
            Console.Write("x =  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int xcopy = x; // used when original x = 0 because of the decrementation

            Console.Write("abs(range) = ");
            int range = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            List<int> output = new List<int>();


            if (x < 0) // negative x
            {

                while (x <= range)
                {
                    output.Add(Curve(x));
                    x++;
                }
            }
            else // positive x
            {
                while (x >= 0)
                {
                    output.Add(Curve(x));
                    x--;
                }

                if (range > xcopy)
                {
                    for (int i = 0; i < xcopy; i++) output.Add(Curve(i));
                }

                else
                {
                    for (int i = x; i < range; i++) output.Add(Curve(i));
                }

                
            }

            Console.WriteLine(string.Join(", ", output.ToArray()));
            
        }

        public static int Curve(int x)
        {
            return (int) Math.Pow(x, 2) - 2*x + 1; // y = x^2 - 2x + 1

        }


  




    }


}
