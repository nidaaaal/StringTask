namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ab = Answer.Product("3,3,3");
            Console.WriteLine(ab);

        }
    }

    public class Answer
    {
        public static int Product(string a)
        {
            int b = 1;
           var arr = a.Split(',');  
    
       
            foreach (var c in arr)
            {
                int c2 = int.Parse(c);  
                b =  b * c2;
            }

            return b;
        }
    } }
