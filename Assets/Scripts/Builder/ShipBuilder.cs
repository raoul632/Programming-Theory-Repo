using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipBuilder 
{

    private Ship SpaceCraft
    {
        get { return SpaceCraft; }
    }
    public abstract void BuildbodyPart();
 

    public abstract void BuildFrontPart();

    public abstract void BuildMissilePart();

    public abstract void BuildReactorPart(); 

    
}
