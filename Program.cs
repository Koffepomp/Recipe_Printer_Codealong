// fisksås

ShowHeader();
AskUser();

void ShowHeader()
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("              RECIPE PRINTER               ");
    Console.WriteLine("-------------------------------------------");
}

void AskUser()
{
    Console.WriteLine("Do you want to add an ingredient to the list?");
    Console.WriteLine("(type Remove to remove an ingredient)");
    Console.WriteLine("(or type Done to show all ingredients)");
    Console.Write("Reply: ");
    string userInput = Console.ReadLine();
}

