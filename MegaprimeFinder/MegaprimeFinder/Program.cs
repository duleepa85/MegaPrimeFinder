// See https://aka.ms/new-console-template for more information

using MegaprimeFinder;

uint input = Convert.ToUInt32(Console.ReadLine());

List<uint> megaPrimeList = MegaPrimeFunction.GetMegaPrimeList(input);
Console.WriteLine("MegaPrime Numbers from 1 to " + input);

foreach (int i in megaPrimeList)
    Console.WriteLine(i);


