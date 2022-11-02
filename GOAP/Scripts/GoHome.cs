﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : GAction
{
    public override bool PrePerform()
    {
        agentBeliefs.RemoveState("atHospital");
        return true;
    }

    public override bool PostPerform()
    {
        Destroy(this.gameObject, 1);
        return true;
    }
}
