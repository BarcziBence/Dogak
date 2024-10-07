using Doga;

List<Versenyzo> Versenyzok = new();

StreamReader sr = new StreamReader("forras.txt");

while (!sr.EndOfStream)
{
    Versenyzok.Add(new(sr.ReadLine()));
}

Console.WriteLine($"A versenyt {Versenyzok.Count} versenyző fejezte be");

//LINQ
// 1
Console.WriteLine("\n 1. Feladat:");
var elitVersenyzok = Versenyzok.Where(v => v.Kategoria == "elit").Count();
Console.WriteLine($"{elitVersenyzok} db versenyző versenyzett elit kategóriában");

// 2
Console.WriteLine("\n 2. Feladat:");
//var eletkorAtlagNok = Versenyzok.Where(v => v.Nem == 'n').Average(v => DateTime.Now.Year - v.SzulEv);
//Console.WriteLine($"A női versenyzők átlag életkora: {eletkorAtlagNok}");

// 3
Console.WriteLine("\n 3. Feladat:");
var osszKerekpar = Versenyzok.Sum(v => v.Kerekpar.TotalSeconds)/3600;
Console.WriteLine("A versenyzők összesen {0:0.00} órát töltöttek kerékpározással", osszKerekpar);

// 4
Console.WriteLine("\n 4. Feladat:");
var elitJAtlagUszas = TimeSpan.FromSeconds(Versenyzok.Where(v => v.Kategoria == "elit junior").Average(v => v.Uszas.TotalSeconds));
Console.WriteLine($"Az elit junior kategóriában úszással töltött idő átlaga : {elitJAtlagUszas}");

// 5
//Console.WriteLine("\n 5. Feladat:");
//var ferfiGyoztes = Versenyzok.Where(v => v.Nem == 'f').Min(v => v.Uszas.TotalSeconds + v.ElsoDepo.TotalSeconds + v.Kerekpar.TotalSeconds + v.MasodikDepo.TotalSeconds + v.Futas.TotalSeconds);
//Console.WriteLine(ferfiGyoztes);

// 6
Console.WriteLine("\n 6. Feladat:");
var kategoriaSzerint = Versenyzok.GroupBy(v => v.Kategoria);
foreach(var a in kategoriaSzerint)
{
    Console.WriteLine($"{a.Key} : {a.Count()}");
}

// 7
Console.WriteLine("\n 7. Feladat:");
var kategoriaSzerintAtlag = Versenyzok.GroupBy(v => v.Kategoria);
foreach (var a in kategoriaSzerint)
{
    Console.WriteLine($"{a.Key} : {TimeSpan.FromSeconds(a.Sum(v => v.ElsoDepo.TotalSeconds) + a.Sum(v => v.MasodikDepo.TotalSeconds))}");
}