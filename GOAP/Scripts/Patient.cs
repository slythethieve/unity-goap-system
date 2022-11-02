using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWaiting", 1, true);
        SubGoal s2 = new SubGoal("isTreated", 1, true);
        goals.Add(s1, 3);
        goals.Add(s2, 5);

        SubGoal s3 = new SubGoal("goHome", 1, true);
        goals.Add(s3, 1);
        SubGoal s4 = new SubGoal("bathroom", 1, false);
        goals.Add(s4, 4);
        Invoke("GoToBathroom", Random.Range(10f, 20f));
    }


    void GoToBathroom()
    {
        beliefs.ModifyState("needForWC", 0);
        Invoke("GoToBathroom", Random.Range(20, 30));
    }
}
