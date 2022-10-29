/*
Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.
*/

using System;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

int[] num = new int[n];

for (var i = 0; i < num.Length; i++)
{
  num[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(MajorityElement(num));

static int MajorityElement(int[] nums)
{
  int major = nums[0];
  int count = 1;

  for (var i = 0; i < nums.Length; i++)
  {
    if (major == nums[count++])
    {
      major = nums[i];
      count++;
    }
    else
    {
      if (major == nums[i])
      {
        count++;
      }
      else
      {
        count--;
      }
    }
  }

  return major;

}