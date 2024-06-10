namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] nums = [0, 1, 0, 3, 12];

            int count = 0;
            
            for (int i = 0; i < nums.Length; i++) 
            { 
                if (nums[i] != 0) 
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            while (count < nums.Length) 
            {
                nums[count] = 0;
                count++;
            }
            for (int i = 0; i < nums.Length; ++i) 
            {
                Console.Write(nums[i]+ " ");
            }
        }
       
    }
}
