using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShipBuilder 
{

    protected  abstract void BuildbodyPart();


    protected abstract void BuildFrontPart();

    protected abstract void BuildMissilePart();

    protected abstract void BuildReactorPart(); 

    
}
