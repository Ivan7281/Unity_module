using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector1 = new Vector3 (5, 5, -7);
        Vector3 vector2 = new Vector3 (0, 8, -6);
        float sqrDifference = (vector1 - vector2).sqrMagnitude;

        Debug.Log("Квадрат довжини їх різниці = " + sqrDifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
