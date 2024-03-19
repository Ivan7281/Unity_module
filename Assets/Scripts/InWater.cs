using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InWater : MonoBehaviour
{
    [SerializeField] private float waterDrag = 1;
    [SerializeField] private float waterAngularDrag = 1;
    private WaterOn isInWater;
    private Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        isInWater = GetComponent<WaterOn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isInWater.isIntoWater)
        {
            rg.drag = waterDrag;
            rg.angularDrag = waterAngularDrag;
        }
    }
}
