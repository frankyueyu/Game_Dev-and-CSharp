class Sort
{
    public static int[] SortDescending(int n, int[] nums)
    {
        int[] sorted = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int biggest = nums[0];
            int smallest = nums[0];
            foreach (int j in nums)
            {
                if (j > biggest)
                {
                    biggest = j;
                }

                if (j < smallest)
                {
                    smallest = j;
                }
            }
            sorted = [.. sorted, biggest];
            nums[nums.IndexOf(biggest)] = nums[nums.IndexOf(smallest)] - 1;
            // int setindex = (nums.IndexOf(biggest) != 0) ? 0 : 1;
            // nums[nums.IndexOf(biggest)] = nums[setindex];
        }
        return sorted;
    }
}