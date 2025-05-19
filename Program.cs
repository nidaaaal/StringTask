namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ab = Answer.Product("123");
            Console.WriteLine(ab);

        }

    }

    public class Answer
    {
        public static int Product(string a)
        {
            int b = 1;
       
            foreach (var item in a)
            {
                int c = Convert.ToInt32(item);

                int d =  b * c;

                b += d;


            }
            Console.WriteLine(b);

            return b;
        }
    } }
