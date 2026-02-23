using UnityEngine;

public class BinarySearchDemo : MonoBehaviour
{
    int[] numbers = { 3, 7, 9, 11, 12, 37 };

    void Start()
    {
        int target = 11;
        int result = BinarySearch(numbers, target);

        if (result != -1)
            Debug.Log("Element found at index: " + result);
        else
            Debug.Log("Element not found");
    }

    int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;

            else if (arr[mid] < target)
                left = mid + 1;

            else
                right = mid - 1;
        }
        return -1;
    }
}
