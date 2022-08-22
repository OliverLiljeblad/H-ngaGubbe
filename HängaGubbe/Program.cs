Console.WriteLine("Mata in ett ord");
string rättOrd = Console.ReadLine();

Console.Write("Gissa ett ord: ");
string ord = Console.ReadLine();
if (rättOrd == ord) {
    Console.WriteLine("Du vann");
    }
    else {
    Console.WriteLine("Du förlorade");
    }     

Console.ReadLine();
