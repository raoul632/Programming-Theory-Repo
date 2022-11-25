using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowLargeCargoShip : Ship
{
    // Start is called before the first frame update
    

    protected override void BuildbodyPart()
    {
        
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModuleCorpsTransporteur")));
    }

    protected override void BuildFrontPart()
    {
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModuleCoc")));
    }

    protected override void BuildMissilePart()
    {
        
    }

    protected override void BuildReactorPart()
    {
        shipBuild.Add(Instantiate(Scenemanager.Instance.brocanteur.GetpartShip("ModulePropulseur2")));
    }

    public override void BuildShip()
    {
        BuildbodyPart();
        BuildFrontPart();
        BuildMissilePart();
        BuildReactorPart(); 
        foreach (GameObject go in shipBuild)
        {
            Instantiate(go); 
        }
    }

    public override void DestroyShip()
    {
        for(int i = shipBuild.Count - 1; i > -1; --i)
        {
            Destroy(shipBuild[i]);
            shipBuild.RemoveAt(i);
        }
        shipBuild.Clear();
    }



}
