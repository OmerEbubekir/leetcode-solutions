 
	
Console.WriteLine("Başlangic degerini giriniz");
int m=int.Parse(Console.ReadLine());	
Console.WriteLine("Başlangic degerini giriniz");
int n=int.Parse(Console.ReadLine());	


    for (int i = m; i <= n; i++)
    {   
        double sumofsquares=0;
        //sayının bölenlerini bulma
        for (int j = 1; j <= i; j++)
        {
            int control= i%j;
        
            if (control==0)
            {
                sumofsquares+=(j*j);
                
            }
        }
            
        if ((Math.Sqrt(sumofsquares)%1==0) ) //karekökü tam sayı mı 
        {
            Console.Write($"[{i},{sumofsquares}]");
        
        }
	}
    
     