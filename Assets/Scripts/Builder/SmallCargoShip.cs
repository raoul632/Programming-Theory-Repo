using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCargoShip : Ship
{
    protected override void BuildbodyPart()
    {
        shipBuild.Add(Scenemanager.Instance.brocanteur.GetpartShip("ModuleCorps"));
    }

    protected override void BuildFrontPart()
    {
        shipBuild.Add(Scenemanager.Instance.brocanteur.GetpartShip("ModuleCoc"));
    }

    protected override void BuildMissilePart()
    {

    }

    protected override void BuildReactorPart()
    {
        shipBuild.Add(Scenemanager.Instance.brocanteur.GetpartShip("ModulePropulseur4"));
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
        foreach (GameObject go in shipBuild)
        {
            Destroy(go);
        }
    }
}
