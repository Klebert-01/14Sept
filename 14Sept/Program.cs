// Objektorienterad programmering, Konstruktor och inkapsling

Cat cat1 = new Cat("Assar", 7); //SKAPA ett nytt objekt utifrån klassen Cat
Console.Write($"Den första nya katten heter {cat1.name} och är {cat1.age} år gammal. ");
cat1.SetToInsured();

if (cat1.SetToInsured() == true)
    Console.WriteLine($"{cat1.name} är försäkrad!\n");
else
    Console.WriteLine($"Katten kan inte försäkras då den saknar namn.\n");

Cat cat2 = new Cat("", 4);
Console.Write($"Den andra nya katten heter {cat2.name} och är {cat2.age} år gammal. ");
cat2.SetToInsured();

if (cat2.SetToInsured() == true)
    Console.WriteLine($"{cat2.name} är försäkrad!\n");
else
    Console.WriteLine($"Katten kan inte försäkras då den saknar namn.\n");

Bil bil1 = new Bil("Volvo", "V70", "ABC123");
Console.WriteLine($"Den nya bilen i garaget är tillverkad av {bil1.tillverkare} och av modellen {bil1.modell}. Regnummer är {bil1.regNummer}");
