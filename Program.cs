int[]TwoNums(int[] nums , int target)
{
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();
    
    int[] numsForTarget = {};
   for(int i = 0; i<=nums.Length-1; i++)
    {
        int searchVal = target - nums[i];
        int searchValIndex = Array.IndexOf(nums, searchVal, i+1);
       
        if(searchVal == nums[i] && searchValIndex == i )
        {
            continue;
        }
        else
        {
            int secondValueIndex = searchValIndex;
            if (secondValueIndex != -1)
            {
                int firstValueIndex = Array.IndexOf(nums, nums[i]);
               
                numsForTarget = numsForTarget.Append(firstValueIndex).ToArray();
                numsForTarget = numsForTarget.Append(secondValueIndex).ToArray();
                break;
            }
        }
        
    }
    watch.Stop();
    string elapsedTime = watch.Elapsed.ToString();
    return numsForTarget;
   
}

int[] nums = { 2,2,5,6,1,3,19,10,23,14,5,6,7,8,4,5,2,5,7 };
int target = 29;

Console.WriteLine(TwoNums(nums, target).ToString());