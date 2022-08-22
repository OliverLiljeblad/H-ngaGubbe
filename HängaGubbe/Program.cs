string rättOrd = "Hej";

        Console.Write("Gissa ett ord: ");
        string ord = Console.ReadLine();
        if (rättOrd == ord) {
            Console.WriteLine("Du vann");
        }
        else {
            Console.WriteLine("Du förlorade");
        }