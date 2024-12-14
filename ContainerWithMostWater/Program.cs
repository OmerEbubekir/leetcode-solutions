int[] height = [1,8,6,2,5,4,8,3,7];
int outp=0;

for (int i = 0; i < height.Length-1; i++)
{   
    int container=0;        // alan degişkeni
    for (int j = height.Length-1; j >=0; j--)
    {
        if (height[i]<=height[j])
        {
            container=height[i]*(j-i);  //indexler arası mesafe carpı kücük olan degişken cümkü su kücüge göre dolar
        }
        else if (height[j]<=height[i])
        {
            container=height[j]*(j-i);
        }

        if (outp<container)     // kontrol esnasında eger alan bir öncekinden büyükse onu en büyük ata
        {
            outp=container;
        }
        
    }
}
Console.WriteLine("Max Container"+outp);