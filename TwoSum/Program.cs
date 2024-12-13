

Console.Write("Kaç boyutta bir dizi girmek istiyorsunuz: ");
int length = int.Parse(Console.ReadLine());

Console.Write("Hedef kaç: ");
int target = Convert.ToInt16(Console.ReadLine());

// Dizi oluşturuluyor
int[] nums = new int[length];

// Kullanıcıdan dizi elemanlarını alıyoruz
for (int i = 0; i < length; i++)
{
    Console.Write($"{i}. değeri giriniz: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}


//dizideki elemanları ikili şekilde toplayarak thedef sayıyya ulaşıyor mu konsole 

for (int i = 0; i < nums.Length/2; i++)
{
int toplam=0;
    for (int j = 0; j < nums.Length; j++)
    {
        toplam=nums[i]+nums[j];
         
         if (toplam==target)
        {
        Console.WriteLine("Girilen dizenin elemanlarının  toplamı hedefi buldu tebrikler ");
        break;
        }
    }
     if (toplam!=target)
    {
    
    Console.WriteLine("başarısız");
    }


}
