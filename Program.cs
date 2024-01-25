/*
 * Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. 
 * Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
 */

int[] nums = new int[50];
int target = 15;

FillArray(nums);
PrintArray(nums);
Find(nums, target);

void Find(int[] nums, int target)
{
  for (int i = 0; i < nums.Length - 2; i++)
  {
    int left = i + 1;
    int right = nums.Length - 1;

    while (left < right)
    {
      int sum = nums[i] + nums[left] + nums[right];

      if (sum == target)
      {
        Console.WriteLine($"{target} = {nums[i]} + {nums[left]} + {nums[right]}");
        break;
      }
      else if (sum < target)
      {
        left++;
      }
      else
      {
        right--;
      }
    }
  }
}

void FillArray(int[] nums)
{
  Random random = new();

  for(int i = 0; i < nums.Length; i++)
  {
    nums[i] = random.Next(10);
  }

  Array.Sort(nums);
}

void PrintArray(int[] nums)
{
  foreach (int i in nums)
  {
    Console.Write(i + " ");
  }

  Console.WriteLine();
}


