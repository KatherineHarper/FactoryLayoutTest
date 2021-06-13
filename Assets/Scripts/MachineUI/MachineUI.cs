using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineUI : MonoBehaviour
{
   
    public GameObject ShowMachinesButton;
    public GameObject HideMachinesButton;
    public GameObject ScrollView;
    


  

   
    public void ShowMachines()
    {
        ShowMachinesButton.GetComponent<Button>().interactable = false;
        HideMachinesButton.GetComponent<Button>().interactable = true;
        ScrollView.SetActive(true);
    }

    public void HideMachines()
    {

        ShowMachinesButton.GetComponent<Button>().interactable = true;
        HideMachinesButton.GetComponent<Button>().interactable = false;
        ScrollView.SetActive(false);
    }

   
}
