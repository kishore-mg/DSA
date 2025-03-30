// [2, 7, 10, 12, 40]
// find the middle index
// check if the number is greater than middle indexed value
// if it is, then we can ignore the left half
// if it is not, then we can ignore the right half
bool BinarySearch(int[] arr, int target) {
    int left = 0;
    int right = arr.Length - 1;
    while (left <= right) {
        int middle = (left + right)/2;
        Console.WriteLine(middle);
        if (arr[middle] < target) {
            left = middle + 1;
        } else if (arr[middle] == target) {
            return true;
        } else {
            right = middle - 1;
        }
    }
    
    return false;
}

int[] arr = [2, 7, 10, 12, 40];
Console.WriteLine(BinarySearch(arr, 10));
Console.WriteLine(BinarySearch(arr, 50));