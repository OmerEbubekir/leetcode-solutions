Console.WriteLine("Enter the starting height of the ball:");
double h = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter the bounce factor (between 0 and 1):");
double bounce = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the height of the mom's window:");
double window = Convert.ToDouble(Console.ReadLine());

 int counter = 0;
if (h > 0 && bounce > 0 && bounce < 1 && window > 0)    // Validity checks

{
    if (h>window)
    {
    
        for ( ; h> window  ;counter++)
        {
            h=h*bounce;
    
            if (h>window)
            {
            counter++;

            }
        }
    }
}
else
{
    counter=-1;

}

Console.WriteLine($"The ball is seen {counter} times.");