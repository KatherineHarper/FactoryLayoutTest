using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckifTouchMachine()
    {
        //while moving placement quad around, is quad collider.trigger touching machine collider
        //while quad collider is touching machine collider, quad colour = red
        //while quad colour is red cannot place new machine
        //while qhad collider is [not] touching machine, quad colour = green
        //while quad colour is green, can place new machine
    }
}
