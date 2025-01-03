using System;

int LengthOfList(int[] nums)
{
    if(nums.Length == 0) return 0;

    int[] lengths = new int[nums.Length];

    for(int i = 0; i < nums.Length; i++) lengths[i] = 1;

    for(int i = 1; i < nums.Length; i++){
        for(int j = 0; j < i; j++){
            if(nums[j] < nums[i] && lengths[i] < lengths[j] + 1)
            {
                lengths[i] = lengths[j] + 1;
            }
        }
    }

    int maxLength = 0;

    foreach(int length in lengths)
    {
        maxLength = Math.Max(length, maxLength);
    }
    
    return maxLength;
}

int[] nums = {10,9,2,5,3,7,101,18};

Console.WriteLine("The result is: " + LengthOfList(nums));