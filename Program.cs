using CA241118;

List<Ber> berek = [];

FileStream fs = new FileStream("berek2020.txt", FileMode.Open, FileAccess.Read);
StreamReader sr = new StreamReader(fs, encoding: System.Text.Encoding.UTF8);

sr.ReadLine();

while (!sr.EndOfStream)
{
    berek.Add(new Ber(sr.ReadLine()));
}

sr.Close();
fs.Close();

Console.Write("3. Feladat: ");
Console.WriteLine($"Dolgozók száma: {berek.Count()}");

double avgber = berek.Average(e => e.getFizetes())/1000;

Console.Write("4. Feladat: ");
Console.WriteLine($"Bérek átlaga: {avgber:0.0}");

Console.Write("5. Feladat: ");
string userinput = "";
while(userinput == "")
{
    Console.Write("Kérem a részleg nevét: ");
    userinput = Console.ReadLine();
}
Console.WriteLine("6. Feladat");

var userreszleg = berek.FindAll(e => e.getReszleg() == userinput);
if(userreszleg.Count() > 0)
{
var fizetes = userreszleg.OrderByDescending(e => e.getFizetes()).ToArray()[0];
Console.WriteLine(fizetes.ToString());

}
else
{
    Console.WriteLine("A megadott részleg nem letézik");
}


Console.WriteLine("7. Feladat: Statisztika");
var reszlegek = berek.DistinctBy(e => e.getReszleg()).Select(e => e.getReszleg());
foreach (var reszleg in reszlegek)
{
    int dolgozok = berek.Count(e => e.getReszleg() == reszleg);
    Console.WriteLine($"\t{reszleg} - {dolgozok} fő");
}

