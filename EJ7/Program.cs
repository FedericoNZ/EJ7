using EJ7;

Console.WriteLine("Bienvenido\n");

Billetera[] billeteras = new Billetera[2];

billeteras[0] = new Billetera();
billeteras[1] = new Billetera();

foreach(var item in billeteras)
{
    var index = Array.IndexOf(billeteras, item);
    Console.WriteLine($"Ingrese cuantos billetes de $10 tendrá la billetera {index + 1}:");
    item.BilletesDe10 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese cuantos billetes de $20 tendrá la billetera {index + 1}:");
    item.BilletesDe20 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese cuantos billetes de $50 tendrá la billetera {index + 1}:");
    item.BilletesDe50 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese cuantos billetes de $100 tendrá la billetera {index + 1}:");
    item.BilletesDe100 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese cuantos billetes de $200 tendrá la billetera {index + 1}:");
    item.BilletesDe200 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese cuantos billetes de $500 tendrá la billetera {index + 1}:");
    item.BilletesDe500 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese cuantos billetes de $1000 tendrá la billetera {index + 1}:");
    item.BilletesDe1000 = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n\n====================================================================");
Console.WriteLine($"\nEl valor de la billetera 1 es de ${billeteras[0].Total()}");
Console.WriteLine($"\nEl valor de la billetera 2 es de ${billeteras[1].Total()}");
Console.WriteLine("\n====================================================================");

Console.WriteLine("\nPulse una tecla para pasar todos los billetes a una nueva billetera.");
Console.ReadLine();

Billetera b3 = billeteras[0].Combinar(billeteras[1]);

Console.WriteLine("\n\n====================================================================");
Console.WriteLine($"\nEl valor de la billetera 1 es de ${billeteras[0].Total()}");
Console.WriteLine($"\nEl valor de la billetera 2 es de ${billeteras[1].Total()}");
Console.WriteLine($"\nEl valor de la billetera 3 es de ${b3.Total()}");
Console.WriteLine("\n====================================================================");
Console.ReadLine();