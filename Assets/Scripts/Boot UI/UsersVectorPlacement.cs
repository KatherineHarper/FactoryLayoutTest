using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsersVectorPlacement : MonoBehaviour
{

    public Users_SO UsersVectorPlacementValues;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UsersVectorPlacementValues.vectorOfMachine =
        UsersVectorPlacementValues.machine.GetComponent<Transform>().position;
        Debug.Log(UsersVectorPlacementValues.vectorOfMachine);
    }
    //Persistent data for each machine :
    void SaveUserPlacementValues()
    {
        
    }
}
