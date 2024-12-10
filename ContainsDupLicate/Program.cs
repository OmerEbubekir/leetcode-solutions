int[] nums = [1,1,1,3,3,4,3,2,4,2];
int counter=0;

for (int i = 0; i < nums.Length; i++)
{
    for (int k = 0; k < nums.Length; k++)
    {
        if (nums[i]==nums[k])
        {
            counter++;
        }
    }
}
counter=counter-nums.Length;
if (counter==0)
{
    Console.Write("false");
}

else
{
    Console.Write("True");
}