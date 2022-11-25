using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterShip : Ship
{
    protected override void BuildbodyPart()
    {
        
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModuleCorps"), gameObject.transform));
    }

    protected override void BuildFrontPart()
    {
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModuleCoc"), gameObject.transform));
    }

    protected override void BuildMissilePart()
    {
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModuleMissile"), gameObject.transform));
    }

    protected override void BuildReactorPart()
    {
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModulePropulseur1"), gameObject.transform));
    }

    public override void BuildShip()
    {
        shipBuild = new List<GameObject>();
        BuildbodyPart();
        BuildFrontPart();
        BuildMissilePart();
        BuildReactorPart();
       
    }

    public override void DestroyShip()
    {
        for (int i = shipBuild.Count - 1; i > -1; --i)
        {
            Destroy(shipBuild[i]);
            shipBuild.RemoveAt(i);
        }
        shipBuild.Clear();
    }
}
