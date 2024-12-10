Console.WriteLine("metni gir");
string world=Console.ReadLine();

string bossuz="";
for (int i = 0; i < world.Length; i++)
{
    if ( world[i] != ' ')
    {
        bossuz+=world[i];
    }
}

string tersbossuz="";
foreach (var item in bossuz)
{
    tersbossuz=item+tersbossuz;
}

if (tersbossuz==bossuz)
{
    Console.WriteLine("Girdiginiz metin palindromdur");
}
    else 
    {
        Console.WriteLine("girilen metin palindrom degildir !!!! ");

    }
