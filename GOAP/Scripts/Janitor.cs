using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janitor : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("clean", 1, false);
        goals.Add(s1, 3);
    }
    void GetTired()
    {
        beliefs.ModifyState("exhausted", 0);
       
        Invoke("GetTired", Random.Range(20, 30));
    }

    void GoToBathroom()
    {
        beliefs.ModifyState("needForWC", 0);
        Invoke("GoToBathroom", Random.Range(20, 30));
    }

}
