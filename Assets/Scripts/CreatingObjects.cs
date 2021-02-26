using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{
    public GameObject car;
    public GameObject carPoint;

    public bool createdCar;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (createdCar == false)
        {
            Instantiate(car, carPoint.transform.position, carPoint.transform.rotation);
            createdCar = true;
        }
    }

}
