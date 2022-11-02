using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom : GAction
{
    public override bool PrePerform()
    {

        
        target = GWorld.Instance.GetQueue("bathrooms").RemoveResource();
        if (target == null)
            return false;
        inventory.AddItem(target);
        GWorld.Instance.GetWorld().ModifyState("FreeToilet", -1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetQueue("bathrooms").AddResource(target);
        inventory.RemoveItem(target);
        GWorld.Instance.GetWorld().ModifyState("FreeToilet", 1);
        agentBeliefs.RemoveState("needForWC");
        return true;
    }
}
