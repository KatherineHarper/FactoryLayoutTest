using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceItem : MonoBehaviour
{
    public GameObject ButtonMachine1;
    public GameObject ButtonMachine2;

    public GameObject placetospawn;
    Transform ptstrans;
    //these wil be in a list []
    public GameObject Machine1;
    public GameObject Machine2;


    private void Update()
    {
         ptstrans =  placetospawn.GetComponent<Transform>();

    }
    
           
    
    public void CreateSpawn1()
    {
        
       

                Machine1.SetActive(true);
            Machine1.transform.position = ptstrans.transform.position;
        
        // Creates an instance of the prefab at the current spawn point.
        //Instantiate(Machine, placetospawn.GetComponent<Transform>().position, Quaternion.identity);
        ButtonMachine1.GetComponent<Button>().interactable = false;

    }
public void CreateSpawn2()
{



    Machine2.SetActive(true);
    Machine2.transform.position = ptstrans.transform.position;

// Creates an instance of the prefab at the current spawn point.
//Instantiate(Machine, placetospawn.GetComponent<Transform>().position, Quaternion.identity);
ButtonMachine2.GetComponent<Button>().interactable = false;

    }
}


   



   

