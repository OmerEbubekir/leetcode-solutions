Console.WriteLine("Enter the numbers");
string x=Convert.ToString(Console.ReadLine());
string xnegatifse="";
string outp="";
if (x.StartsWith('-'))
{
    xnegatifse=x.Replace('-',' ');

    for (int i = x.Length-1; i >=0; i--)
    {
    
        outp=outp+xnegatifse[i];

    }
        Console.WriteLine("-"+outp);
}
if (!(x.StartsWith('-')))
{
    
    for (int i = x.Length-1; i >=0; i--)
    {
        
        outp=outp+x[i];

    }
        Console.WriteLine(outp);
}
