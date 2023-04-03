// See https://aka.ms/new-console-template for more information

using MegaprimeFinder;


List<uint> megaPrimeList = MegaPrimeFunction.GetMegaPrimeList(67);
foreach (int i in megaPrimeList)
    Console.WriteLine(i);


