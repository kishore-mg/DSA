//
// Best Case (O(n)) → If the array is already sorted.
// Worst Case (O(n²)) → If the array is reversed.
// 
// Space Complexity: O(1)
// 
// Logic: Repeatedly compare adjacent elements and swap if they are in the wrong order.
// Large elements "bubble up" to the end in each pass.
// Runs (n-1) passes to fully sort the array.
//
void BubbleSort(int[] arr) {
    for (int i=0; i<arr.Length - 1; i++) {
        for (int j=0; j< arr.Length - i - 1; j++){
            if (arr[j] > arr[j+1]) {
                (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
            }
        }
    }
}

int[] input = {10, 5, 18, 12, 11, 13, 44, 22};
BubbleSort(input);
Console.WriteLine(string.Join(", ", input));