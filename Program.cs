List<Product> products = new List<Product>
{
    new Computer("Macbook Pro", "16 inch",2499.99, "A laptop made by Apple",16.8),
    new Computer("Surface Pro", "13 inch", 2399.99, "A laptop made by Microsoft", 15.4),
    new Television("Samsung QLED","65 inch",2999.99,"A smart TV made by Samsung",true),
    new Television("LG Boring TV", "40 inch", 999.99, "A Boring TV made by LG", false)
};

int choice;

do
{ 
    int listNumber = 1;

    Console.WriteLine("0 - - - Exit");
    foreach(Product p in products)
    {
        
        Console.WriteLine($"{listNumber++} - - - {p.Name}");
    }

    Console.Write("Choose a Product:   ");
    choice = Convert.ToInt32(Console.ReadLine());

    int listPosition = 1;


    if (choice > products.Count)
    {
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("That option does not exist.");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
    }

    else
    {
        foreach(Product p in products)
        {
            if (listPosition == choice)
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine($"{p}");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");

                
                Console.Write("Type any character to continue:   ");
                string BreakingString = Console.ReadLine();

                if (BreakingString.Length > 0)
                    break;
            }
            else
            {
                listPosition++;
            }
        }
    }
}
while (choice != 0);




