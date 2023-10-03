namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ListItemsName> list = new List<ListItemsName>()
            { new ListItemsName(101,"milk",2,20),
            new ListItemsName(102,"Darymilk",4,50),
            new ListItemsName(103,"book",2,100),
            };
            PrintItems(list);


            ListItemsName listItemsNam2 = new ListItemsName(1, "akash", 4, 200);
            Console.WriteLine(listItemsNam2);//to string used
        }
       public static void PrintItems(List<ListItemsName> list)
        {
            double totalCost = 0;
            foreach (var item in list)
            {
                Console.WriteLine("asd:"+item);
                totalCost += item.Balance;

            }
            Console.WriteLine(totalCost);
        }

        
    }
}