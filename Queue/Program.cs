internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Queue<string> cities = new Queue<string>();
        cities.Enqueue("Abuja");
        cities.Enqueue("Bramoon");
        cities.Enqueue("Cape-towm");

        foreach (var item in cities)
        {
          //  Console.WriteLine(item);
        }
        Console.WriteLine("element" + cities.Peek());
        Console.WriteLine("cost"+cities.Dequeue());


        var subject = new LinkedList<string>();
        subject.AddLast("physics");
        subject.AddLast("biology");
        subject.AddLast("chemistry");

        LinkedListNode<string> node = subject.Find("biology");
        subject.AddBefore(node, "mathematics");

        foreach (var items in subject)
        {
           // Console.WriteLine(items);
        }
       
        Dictionary<string,string> dict = new Dictionary<string,string>();
        dict.Add("rives", "Port");
        dict.Add("cives", "lort");
        dict.Add("lagos", "ikeja");

        /*foreach ( KeyValuePair <string,string>Kv in dict) {
            Console.WriteLine(Kv.Key + " -" +Kv.Value  );
        }*/

        Dictionary<string, int> goods = new Dictionary<string, int>();

        while (true)
        {

            Console.WriteLine("Welcome to the store");
            Console.WriteLine("here is a list of what we sell ");
            Console.WriteLine("1.bread \n 2.cola \n 3.grapes \n 4.rice \n 5.gear \n 6.cars \n 7.lego \n 8.shoes");

            Console.WriteLine("press 1 to purchase items");
            Console.WriteLine("press 2 to Display your Purchase(s)");




            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)

                
            {
                Console.WriteLine("What would you like to buy");



                string store = Console.ReadLine();
               
                
                Console.WriteLine("And it only one" + store + " you would like to buy" );
                Console.WriteLine("press for \n 1.no \n or 2.yes ");

                int number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("how many");
                    int quantit =int.Parse(Console.ReadLine());
                    Console.WriteLine("so that many "+ quantit);

                }
                
                else if (number == 2) {
                    int quantit = 1;
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("Invalid input please type 'Yes' or 'No'.");
                }
                
               goods.Add(store,number);


                



               

            }
            else if (choice == 2)
            {
                string emoji = "\U0001F604";

                Console.WriteLine($"THANK YOU FOR SHOPPING WITH US, {emoji}!");

                foreach (KeyValuePair<string, int> kv in goods)
                {
                    Console.WriteLine(kv.Key + " -" + kv.Value);
                    Console.WriteLine(goods);
                }
                System.Environment.Exit(0);
            }


        }











    }
}