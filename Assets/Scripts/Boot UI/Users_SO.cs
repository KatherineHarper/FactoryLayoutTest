using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName = "Users_SO", menuName = "Spawnable Item/New Pick-up", order = 1)]
public class Users_SO : ScriptableObject
{
    public GameObject machine;
    public string nameOfUser;
    public Vector3 vectorOfMachine;

    public float rotY;
}
