using UnityEngine;

public class LinearSearchDemo : MonoBehaviour
{
    int[] numbers = { 3, 7, 9, 11, 12, 37 };

    void Start()
    {
        int target = 11;
        int result = LinearSearch(numbers, target);

        if (result != -1)
            Debug.Log("Element found at index: " + result);
        else
            Debug.Log("Element not found");
    }

    int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }
}
