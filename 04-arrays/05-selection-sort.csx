//
// Best Case (O(n²))
// Worst Case (O(n²))
// 
// Space Complexity: O(1)
// 
// Logic: 
// 1. Find the smallest element and swap it with the first position.
// 2. Repeat for the second smallest element and so on.
//
void SelectionSort(int[] arr) {
    for (int i=0; i<arr.Length - 1; i++) {
        var min = i;
        for (int j=i + 1; j < arr.Length; j++){
            if (arr[min] > arr[j]) {
                min = j;
            }
        }
        
        if (i != min) (arr[i], arr[min]) = (arr[min], arr[i]);
    }
}

int[] input = {10, 5, 18, 12, 11, 13, 44, 22};
SelectionSort(input);
Console.WriteLine(string.Join(", ", input));