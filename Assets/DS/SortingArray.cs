using UnityEngine;

public class SortingArray : MonoBehaviour
{
    int[] numbers = { 8, 3, 5, 2, 9, 1, 6 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintArray("Original Array");

        BubbleSort(numbers);
        //SelectionSort(numbers);
        //InsertionSort(numbers);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void PrintArray(string title, int[] arr = null)
    {
        if (arr == null) arr = numbers;
        string result = title + " : ";
        foreach (int n in arr) result += n + " ";
        Debug.Log(result);
    }

    // 🔵 Bubble Sort
    void BubbleSort(int[] arr)
    {
        Debug.Log("Sorting Type: BUBBLE SORT");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        PrintArray("Bubble Sorted", arr);
    }

    // 🟢 Selection Sort
    void SelectionSort(int[] arr)
    {
        Debug.Log("Sorting Type: SELECTION SORT");

        for (int i = 0; i < arr.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
        PrintArray("Selection Sorted", arr);
    }

    // 🟡 Insertion Sort
    void InsertionSort(int[] arr)
    {
        Debug.Log("Sorting Type: INSERTION SORT");

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
        PrintArray("Insertion Sorted", arr);
    }
}
