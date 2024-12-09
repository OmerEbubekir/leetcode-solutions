//int[] numbers = [7,6,4,3,1]; 
int[] numbers = {7, 3, 5, 1, 6, 4};
int min = numbers[0]; 
int max = 0; 
int ksayac=0;
int bsayac=0;

//min sayı bulma döngüsü
for (int i = 0; i < numbers.Length; i++) 
{
    if (numbers[i] < min) 
    {
        min = numbers[i]; 
        ksayac=i;
    }
}
// max sayı döngüsü bulma   
 for ( int k=ksayac; k < numbers.Length ; k++){

     if (numbers[k] > max  ) 
    {
        bsayac=k;
        max = numbers[k]; 
    }
}
int fark=max-min; // farkı bulma 

//Eger max deger min degerden sonra geliyorsa karşılaştırması yapıyor
if (bsayac>ksayac)
{
    Console.WriteLine($"Alış fiyatınız {min} Satış fiyatınız {max} karınız {fark}");

}
else if (bsayac<ksayac ||bsayac==ksayac)
{
    Console.WriteLine("Karlı bir satış günü bulunamadı");
}




