using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOn : MonoBehaviour
{
    public bool isIntoWater = false;
    private void OnTriggerEnter(Collider other)
    {
        isIntoWater = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isIntoWater = false;
    }
}
