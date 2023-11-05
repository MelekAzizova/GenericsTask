namespace GenericsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(){ 2,5,6,9,12} ;
            
          
            Console.WriteLine("List: ");
            foreach (int i in list)
            {
               
                Console.WriteLine(i);
     
            }



            list.Add(20);
            list.Add(51);
            list.Add(19);
            list.Add(2);


            Console.WriteLine("ListAdd: ");
            foreach (int i in list)
            {

                Console.WriteLine(i);

            }

            list.Remove(20);
            list.Remove(5);
            Console.WriteLine("ListRemove: ");
            foreach (int i in list)
            {

                Console.WriteLine(i);

            }
            Console.WriteLine("Enter to number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list.IndexOf(number));

            Console.WriteLine("Enter to number: ");
            int num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list.LastIndexOf(2));








        }
    }
}