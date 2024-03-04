namespace Problems.Day3;

public class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int arr1Pos = m - 1;
        int arr2Pos = n - 1;
        int mergedArrPos = m + n - 1;

        while (arr1Pos >= 0 && arr2Pos >= 0)
        {
            int numInArr1 = nums1[arr1Pos];
            int numInArr2 = nums2[arr2Pos];

            if (numInArr1 <= numInArr2)
            {
                nums1[mergedArrPos] = numInArr2;
                arr2Pos--;
            }
            else
            {
                nums1[mergedArrPos] = numInArr1;
                arr1Pos--;
            }

            mergedArrPos--;
        }

        while (arr2Pos >= 0)
        {
            nums1[mergedArrPos] = nums2[arr2Pos];
            mergedArrPos--; arr2Pos--;
        }
    }
}
