using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml.Serialization;
using System.Xml;
using System.IO;

public class Placement : MonoBehaviour
{


   
    public Transform[] MachineTransform;
    public class MySaveData
    {
        //Transform data to save/load to and from file
        //represents a conversion of a transform object
        //into simpler values, like floats
        [System.Serializable]
        public struct DataTransform
        {
            public string name;
            public bool isActive;
            public float X;
            public float Y;
            public float Z;
  public float RotY;
          

        }

        //Transform object to save
        public DataTransform MyTransform = new DataTransform();
    }


//My Save Data Object declared here
public MySaveData MyData = new MySaveData();
    public MySaveData MyData2 = new MySaveData();


    private void GetMachhineTransforms()
    {

        foreach (var Machine in MachineTransform)
        {  //Get transform component on this object
            Transform Transform = Machine;
            if (Machine.name == "MachineName1")
            {
                //Got transform, now fill data structure
                MyData.MyTransform.X = Transform.position.x;
                MyData.MyTransform.Y = Transform.position.y;
                MyData.MyTransform.Z = Transform.position.z;
            }
            if (Machine.name == "MachineName2")
            {
                //Got transform, now fill data structure
                MyData2.MyTransform.X = Transform.position.x;
                MyData2.MyTransform.Y = Transform.position.y;
                MyData2.MyTransform.Z = Transform.position.z;
            }
        }
      
       
    }

    public void SaveLayout1Button(string FileName = "GameData.xml")
    {
        //Save machine placment vectors under layout_one in memory
        //Get transform data
        GetMachhineTransforms();


        //Now save game data
        XmlSerializer Serializer = new XmlSerializer(typeof(MySaveData));

        FileStream Stream = new FileStream(FileName, FileMode.Create);

        Serializer.Serialize(Stream, MyData);

        Stream.Close();
        layoutOneText.text = "Layout 1 saved";
       
    }
  
}
