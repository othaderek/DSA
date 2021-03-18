using System;
using System.Linq;
/*
Given 2 sorted arrays find the median
*/
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = nums1.Concat(nums2).ToArray();
        Array.Sort(merged);
        double result = 0.0;
        
        if (merged.Length == 1) return merged[0];
        
        if (merged.Length % 2 != 0)
        {
            return merged[merged.Length/2];
        } else if (merged.Length % 2 == 0)
        {
            int leftIdx = merged.Length/2 - 1;
            int rightIdx = leftIdx + 1;
            result = merged[leftIdx] + merged[rightIdx];
            return (double)result/2;
        }
        return result;
    }
}
