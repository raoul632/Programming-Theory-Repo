using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterShip : Ship
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
        shipBuild.Add(Scenemanager.Instance.brocanteur.GetpartShip("ModuleMissile"));
    }

    protected override void BuildReactorPart()
    {
        shipBuild.Add(Scenemanager.Instance.brocanteur.GetpartShip("ModulePropulseur1"));
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
