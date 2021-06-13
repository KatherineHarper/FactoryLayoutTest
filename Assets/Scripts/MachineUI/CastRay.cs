using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastRay : MonoBehaviour
{

    GameObject buttonName;

    //OAttached to each machine, if laser hits machine, machine disappears
    void Update()
    {
        HideMachine();
    }

    void HideMachine()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    // hit.collider.enabled = false;
                    gameObject.SetActive(false);
                    EnableMachineButton();
                }
            }
        }
    }

    void EnableMachineButton()
    {

        buttonName = GameObject.Find(gameObject.name);
        buttonName.GetComponent<Button>().interactable = true;
    }
}
