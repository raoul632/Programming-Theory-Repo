using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ship : MonoBehaviour, IShipBuilder
{
    private string shipType;
   
    protected List< GameObject> shipBuild;
    protected GameObject myShip; 


    public void Initialize(string _shipType)
    {
        shipType = _shipType; 
    }

    protected virtual void BuildbodyPart()
    {
        throw new System.NotImplementedException();
    }

    protected virtual void BuildFrontPart()
    {
        throw new System.NotImplementedException();
    }

    protected virtual void BuildMissilePart()
    {
        throw new System.NotImplementedException();
    }

    protected virtual void BuildReactorPart()
    {
        throw new System.NotImplementedException();
    }

    public abstract void BuildShip();

    public abstract void DestroyShip();

    void IShipBuilder.BuildbodyPart()
    {
        throw new System.NotImplementedException();
    }

    void IShipBuilder.BuildFrontPart()
    {
        throw new System.NotImplementedException();
    }

    void IShipBuilder.BuildMissilePart()
    {
        throw new System.NotImplementedException();
    }

    void IShipBuilder.BuildReactorPart()
    {
        throw new System.NotImplementedException();
    }
}
