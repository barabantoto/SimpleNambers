using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNum
{
    class Program
    {
        static void Main(string[] args)
        {
            MasFiller(20000);
            Console.ReadLine();
        }
        static void MasFiller(int to)
        {
            List<int> nums = new List<int>();
            for (int i = 2; i <= to ; i++)
                nums.Add(i);
            
            for (int i = 2; i < to - 1; i++)
                if (nums[i] != 0)
                    NotSimpleNumbersRemover(nums,i);
            ListShower(nums,to);
        }
        static void NotSimpleNumbersRemover(List<int> nums,int number)
        {
            
            for (int a = 2; number * a <= nums.Count + 1; a++)
                nums[(number * a) - 2] = 0;
        }
        static void ListShower(List<int> nums,int to)
        {
            nums.RemoveAll(item => item == 0);
            foreach (var i in nums)
                Console.Write("{0}, ", i);
        }
    }
}
