//
// Time Complexity: O(n)
// Space Complexity: O(1)
//
// Use When: You have an unsorted array or small.
// Logic: Traverse the array one by one until you find the target.
//
bool LinearSearch(int[] arr, int x)
{
    for (int i=0; i < arr.Length; i++) {
        if (arr[i] == x) {
            return true;
        }
    }

    return false;
}

int[] arr = { 2, 3, 4, 10, 40 };
Console.WriteLine(LinearSearch(arr, 10)); // True
Console.WriteLine(LinearSearch(arr, 12)); // False
Console.WriteLine(LinearSearch(arr, 13)); // False
Console.WriteLine(LinearSearch(arr, 40)); // True