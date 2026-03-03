using UnityEngine;
using System.Collections.Generic;

public class ListExampleListExample : MonoBehaviour
{

    List<string> bcaGDStudents = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcaGDStudents.Add("Alok1");  //0
        bcaGDStudents.Add("Alok2");  //1
        bcaGDStudents.Add("Alok3");  //2
        bcaGDStudents.Add("Alok4");
        bcaGDStudents.Add("Alok5");
        bcaGDStudents.Add("Alok3");

        //for (int i = 0; i < bcaGDStudents.Count; i++)
        //{
        //    Debug.Log(bcaGDStudents[i]);
        //}


        foreach (string s in bcaGDStudents)
        {
            Debug.Log(s);
        }

        bcaGDStudents[3] = "Aditya4";

        foreach (string s in bcaGDStudents)
        {
            Debug.Log(s);
        }

        bcaGDStudents.Remove("Alok3");
        bcaGDStudents.Remove("Alok3");
        bcaGDStudents.Remove("Alok3");
        foreach (string s in bcaGDStudents)
        {
            Debug.Log(s);
        }

        Debug.Log(bcaGDStudents[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
