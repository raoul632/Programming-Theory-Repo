using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private string shipType;
    private Dictionary<string, GameObject> shipPart = new Dictionary<string, GameObject>();


    public void Initialize(string _shipType)
    {
        shipType = _shipType; 
    }
    public GameObject this[string key]
    {
        get { return shipPart[key];  }
        set { shipPart[key] = value;  }
    }
   

    
}
