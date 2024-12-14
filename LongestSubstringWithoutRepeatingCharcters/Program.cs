string s = "abcabcbb";
int[] outp =new int[s.Length];
char ilkKarakter = s[0];
bool hepsiAyni = true;

foreach (char karakter in s)
{
    if (karakter != ilkKarakter)
    {
        hepsiAyni = false;
        break;
    }
}

for (int i = 0; i < s.Length; i++)
{
    int counter=0;
    for (int k = 0; k < s.Length; k++)
    {
        if (s[i]!=s[k])
        {
            counter++;
         //Console.WriteLine("aa"+counter);

        }
        if (s[i]==s[k])
        {
            counter--;
            //Console.WriteLine("bbb"+counter);
        }
      
    }
    outp[i]=counter;
}
Console.WriteLine(hepsiAyni ? "Bütün elemanlar aynı. 1" 
: "Elemanlar farklı."+(outp.Max()-1));
