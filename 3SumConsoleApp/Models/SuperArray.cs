using System;
using System.Collections.Generic;

namespace _3SumConsoleApp.Models
{
    public class SuperArray
    {
        public static List<List<int>> GetThreeSum(int[] numbers)
        {
            Array.Sort(numbers);
            var list = new List<List<int>>();

            for (int i = 0; i < numbers.Length && numbers[i] <= 0; ++i)
            {
                int pin = numbers[i];
                int find = -pin;
                int left = i + 1;
                int right = numbers.Length - 1;

                if (i > 0 && pin == numbers[i - 1]) continue;

                while (left < right)
                {
                    if (numbers[left] + numbers[right] == find)
                    {
                        list.Add(new List<int> { numbers[i], numbers[left++], numbers[right--] });
                        while (left < right && numbers[left] == numbers[left - 1]) ++left;
                    }
                    if (numbers[left] + numbers[right] < find) ++left;
                    if (numbers[left] + numbers[right] > find) --right;
                }
            }

            return list;
        }
    }
}
