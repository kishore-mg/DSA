//
// Best Case (O(n))
// Worst Case (O(n²))
// 
// Space Complexity: O(1)
// 
// Logic: 
// 1. Pick an element and insert it into the correct position in the sorted part of the array.
// 2. Works like sorting playing cards in your hand.
//
void InsertionSort(int[] arr) {
    int n = arr.Length;
    for (int i = 1; i < n; i++) {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}

// Example
int[] arr = {10, 5, 18, 12, 11, 13, 44, 22};
InsertionSort(arr);
Console.WriteLine(string.Join(", ", arr)); // Output: 5, 6, 11, 12, 13