using UnityEngine;

public class TwoDArrayExample : MonoBehaviour
{
    int[,] marks;
    void Start()
    {
        // 3 Rows, 3 Columns
        marks = new int[3, 3]
        {
            { 80, 75, 90 },
            { 60, 85, 70 },
            { 88, 92, 78 }
        };

        // Print all values
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Debug.Log("Marks[" + row + "," + col + "] = " + marks[row, col]);
            }
        }
    }
}
