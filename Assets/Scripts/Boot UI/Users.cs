using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Users : MonoBehaviour
{


    public GameObject User1;
    public GameObject User2;

 
    public void UserButtonOne()
    {
        //if this button chosen/ simulation will boot with User1 as the avatar for memory of item placement
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        DontDestroyOnLoad(User1.gameObject);
    }

    public void UserButtonTwo()
    {
        //if this button chosen/ simulation will boot with User2 as the avatar for memory of item placement
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        DontDestroyOnLoad(User2.gameObject);
    }
}
