using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;

using System.IO;
//Saving data as xml
//TODO
//1. change this to attach to UImanager 
//2. Test on android

public class SaveLayout : MonoBehaviour
{
    [System.Serializable]
    [XmlRoot("GameData")]
    public class MySaveData//save layout vector data
    {
        //Transform data to save/load to and from file
        //represents a conversion of a transform object
        //into simpler values, like floats
        [System.Serializable]
        public struct DataTransform
        {
            public float X;
            public float Y;
            public float Z;
            public float RotX;
            public float RotY;
            public float RotZ;
        }

        //Transform object to save
        public DataTransform MyTransform = new DataTransform();

    }
    public Text layoutOneText;

    
    //Saves game data to XML file
    //Call this function to save data to an XML file
    //Call as Save

    //My Save Data Object declared here
    public MySaveData Machine1Data = new MySaveData();
  
    //-----------------------------------------------
    //Populate structure MyData with transform data
    //This is the data to be saved to a file
    private void GetTransformMachine1()
    {
        //Get transform component on this object
        Transform TransformMachine1 = transform;

        //Got transform, now fill data structure
        Machine1Data.MyTransform.X = TransformMachine1.position.x;
        Machine1Data.MyTransform.Y = TransformMachine1.position.y;
        Machine1Data.MyTransform.Z = TransformMachine1.position.z;
        Machine1Data.MyTransform.RotY = TransformMachine1.localRotation.eulerAngles.y;
    }

    //-----------------------------------------------
    //Restore the transform component with loaded data
    //Call this function after loading data back from a file
    // for restore
    private void SetTransform()
    {
        //Get transform component on this object
        Transform ThisTransform = transform;

        //We got the transform component, now restore data
        ThisTransform.position = new Vector3(Machine1Data.MyTransform.X, Machine1Data.MyTransform.Y, Machine1Data.MyTransform.Z);

        ThisTransform.rotation = Quaternion.Euler(Machine1Data.MyTransform.RotX, Machine1Data.MyTransform.RotY, Machine1Data.MyTransform.RotZ);

        

    }
    //-----------------------------------------------



    public void SaveLayout1Button(string FileName = "GameData.xml")
    {
        //Save machine placment vectors under layout_one in memory
        //Get transform data
        GetTransformMachine1();
      

        //Now save game data
        XmlSerializer Serializer = new XmlSerializer(typeof(MySaveData));

        FileStream Stream = new FileStream(FileName, FileMode.Create);

        Serializer.Serialize(Stream, Machine1Data);
     
        Stream.Close();
        layoutOneText.text = "Layout 1 saved";
    }

    public void SaveLayout2Button()//stringgamedata?)
    {
        //Save machine placment vectors under layout_two in memory


    }

    //Load game data from XML file
    //Call this function to load data from an XML file
    //Call as Load


    //-----------------------------------------------Load Data
    public void LoadLayout1Button(string FileName = "GameData.xml")
    {
        //If file doesn’t exist, then exit
        if (!File.Exists(FileName)) {
            Debug.Log("file doesn’t exist");
        }

        XmlSerializer Serializer = new XmlSerializer(typeof(MySaveData));

        FileStream Stream = new FileStream(FileName, FileMode.Open);

        Machine1Data = Serializer.Deserialize(Stream) as MySaveData;

        Stream.Close();
        layoutOneText.text = "Layout 1 loaded";

        //Set transform - load back from a file
        SetTransform();
    }
    //-----------------------------------------------
   
    //-----------------------------------------------
}




    
