using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brocanteur 
{
    // Start is called before the first frame update
    protected Dictionary<string, GameObject> shipPart = new Dictionary<string, GameObject>();

    public GameObject this[string key]
    {
        get { return shipPart[key]; }
        set { shipPart[key] = value; }
    }

    public void AddPartShip(string name ,GameObject _shipPart)
    {
        shipPart.Add(name, _shipPart); 
    }

    public GameObject GetpartShip(string name)
    {
        return shipPart[name]; 
    }
  
}
