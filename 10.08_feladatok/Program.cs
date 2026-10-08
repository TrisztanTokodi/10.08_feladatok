Console.OutputEncoding = System.Text.Encoding.UTF8;
// I/1

Console.Write("Add meg az életkorod: ");
int eletkor = Convert.ToInt32(Console.ReadLine());
int nagykoru = 18;
if (eletkor >= nagykoru)
{
    Console.WriteLine("Nagykorú vagy.");
}
else
{
    Console.WriteLine($"Nem vagy nagykorú, {nagykoru - eletkor} év kell még hogy nagykorú legyél.");
}

Console.WriteLine("----------------");

// I/2
Console.Write("Adj meg egy egész számot: ");
int szam = Convert.ToInt32(Console.ReadLine());
if (szam % 2 == 0)
{
    Console.WriteLine("A megadott szám páros.");
}
else
{
    Console.WriteLine("A megadott szám páratlan.");
}

Console.WriteLine("----------------");

// I/3
Console.Write("Adj meg egy jelszót: ");
string jelszo = Console.ReadLine();
if (jelszo == "tengerpart")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Belépés engedélyezve.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Hibás jelszó.");
    Console.ResetColor();
}

Console.WriteLine("----------------");

// I/4
Console.Write("Add meg a rendelésed értékét forintban: ");
decimal rendeles = Convert.ToDecimal(Console.ReadLine());
int ingyenessz = 15000;
int szallitas = 1500;
if (rendeles >= ingyenessz)
{
    Console.WriteLine($"A rendelésed ingyenes szállítással érkezik, {rendeles} Ft-ért.");
}
else
{
    Console.WriteLine($"A rendelésed {rendeles + szallitas:N0} Ft-ért érkezik.");
}

Console.WriteLine("----------------");

// I/5
Console.Write("Adj meg egy számot: ");
double szam1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Adj meg még egy számot: ");
double szam2 = Convert.ToDouble(Console.ReadLine());
if (szam1 > szam2)
{
    Console.WriteLine($"A nagyobb szám: {szam1}, ennyivel: {szam1 - szam2}");

}
else if (szam1 < szam2)
{
    Console.WriteLine($"A nagyobb szám: {szam2}, ennyivel: {szam2 - szam1}");
}
else
{
    Console.WriteLine("A két szám egyenlő.");
}

Console.WriteLine("----------------");

// I/6
Console.Write("Adj meg egy egész számot: ");
string talanszam = Console.ReadLine();
bool szame = int.TryParse(talanszam, out int szam6);

if (szame == true)
{
    Console.WriteLine($"A  szám kétszerese : {szam6 * 2} \nA szám négyzete: {szam6 * szam6}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ez nem egész szám.");
    Console.ResetColor();
}

Console.WriteLine("----------------");

// II/7
Console.Write("Add meg a kinti hőmérsékletet: ");
double homers = Convert.ToDouble(Console.ReadLine());
if (homers < 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Fagy van.");
    Console.ResetColor();
}
else if (homers >= 0 && homers <= 15)
{
    Console.WriteLine("Hűvös van.");
}
else if (homers > 15 && homers <= 25)
{
    Console.WriteLine("Kellemes az idő.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Meleg az idő.");
    Console.ResetColor();
}

Console.WriteLine("----------------");

// II/8
Console.Write("Add meg az osztályzatod: ");
int jegy = Convert.ToInt32(Console.ReadLine());
if (jegy == 1)
{
    Console.WriteLine("Elégtelen");
}
else if (jegy == 2)
{
    Console.WriteLine("Elégséges");
}
else if (jegy == 3)
{
    Console.WriteLine("Közepes");
}
else if (jegy == 4)
{
    Console.WriteLine("Jó");
}
else if (jegy == 5)
{
    Console.WriteLine("Jeles");
}
else
{
    Konzol.Hiba("Nem értelmezett");
}

Console.WriteLine("----------------");

// II/9
Console.Write("Add meg a dolgozat pontszámát: ");
int pontszam = Convert.ToInt32(Console.ReadLine());
if (pontszam >= 0 && pontszam <= 39)
{
    Console.WriteLine("Elégtelen");
}
else if (pontszam >= 40 && pontszam <= 54)
{
    Console.WriteLine("Elégséges");
}
else if (pontszam >= 55 && pontszam <= 69)
{
    Console.WriteLine("Közepes");
}
else if (pontszam >= 70 && pontszam <= 84)
{
    Console.WriteLine("Jó");
}
else if (pontszam >= 85 && pontszam <= 100)
{
    Console.WriteLine("Jeles");
}
else
{
    Konzol.Hiba("Nem értelmezett");
}

Console.WriteLine("----------------");

// II/10
Console.Write("Add meg az egyik hónap sorszámát: ");
int honap = Convert.ToInt32(Console.ReadLine());
if (honap == 1){
    Console.WriteLine("Január hónap van, ami 31 napos");
}
else if (honap == 2){
    Console.WriteLine("Február hónap van, ami 28 napos");
}
else if(honap == 3){
    Console.WriteLine("Március hónap van, ami 31 napos");
}
else if(honap == 4){
    Console.WriteLine("Április hónap van, ami 30 napos");
}
else if(honap == 5){
    Console.WriteLine("Május hónap van, ami 31 napos");
}
else if(honap == 6){
    Console.WriteLine("Június hónap van, ami 30 napos");
}
else if(honap == 7){
    Console.WriteLine("Július hónap van, ami 31 napos");
}
else if(honap == 8){
    Console.WriteLine("Augusztus hónap van, ami 31 napos");
}
else if(honap == 9){
    Console.WriteLine("Szeptember hónap van, ami 30 napos");
}
else if(honap == 10){
    Console.WriteLine("Október hónap van, ami 31 napos");
}
else if(honap == 11){
    Console.WriteLine("November hónap van, ami 30 napos");
}
else if(honap == 12){
    Console.WriteLine("December hónap van, ami 31 napos");
}
else
{
    Konzol.Hiba("Nem értelmezett");
}

Console.WriteLine("----------------");

// II/11
Console.Write("Add meg az életkorod: ");
int jegykor = Convert.ToInt32(Console.ReadLine());
if (jegykor == 6)
{
    Console.WriteLine("Neked ingyenes a bérlet.");
}
else if (jegykor >= 7 && jegykor <= 17)
{
    Console.WriteLine("Neked 1500 Ft a bérlet a bérlet(diák).");
}
else if (jegykor >= 18 && jegykor <= 64)
{
    Console.WriteLine("Neked teljes árú a bérlet(felnőtt).");
}
else if (jegykor >= 65 && jegykor <= 120)
{
    Console.WriteLine("Neked 1800 Ft a bérlet(nyugdíjas).");
}
else
{
    Konzol.Hiba("Nem értelmezett");
}

Console.WriteLine("----------------");

// II/12
Console.Write("Írj be egy kis karaktert ékezet nélkül: ");
ConsoleKeyInfo billentyu = Console.ReadKey();
Console.WriteLine();
if (billentyu.KeyChar == 'a' || billentyu.KeyChar == 'e' || billentyu.KeyChar == 'i' || billentyu.KeyChar == 'o' || billentyu.KeyChar == 'u')
{
    Console.WriteLine("A megadott karakter magánhangzó.");
}
else if (billentyu.KeyChar == 'b' || billentyu.KeyChar == 'c' || billentyu.KeyChar == 'd' || billentyu.KeyChar == 'f' || billentyu.KeyChar == 'g' || billentyu.KeyChar == 'h' || billentyu.KeyChar == 'j' || billentyu.KeyChar == 'k' || billentyu.KeyChar == 'l' || billentyu.KeyChar == 'm' || billentyu.KeyChar == 'n' || billentyu.KeyChar == 'p' || billentyu.KeyChar == 'q' || billentyu.KeyChar == 'r' || billentyu.KeyChar == 's' || billentyu.KeyChar == 't' || billentyu.KeyChar == 'v' || billentyu.KeyChar == 'w' || billentyu.KeyChar == 'x' || billentyu.KeyChar == 'y' || billentyu.KeyChar == 'z')
{
    Console.WriteLine("A megadott karakter mássalhangzó.");
}
else
{
    Konzol.Hiba("Nem értelmezett karakter.");
}

Console.WriteLine("----------------");

// II/13
