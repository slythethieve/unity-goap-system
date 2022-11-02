using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("treatPatient", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("resting", 1, false);
        goals.Add(s2, 1);

        SubGoal s3 = new SubGoal("bathroom", 1, false);
        goals.Add(s3, 4);
        Invoke("GoToBathroom", Random.Range(10f, 20f));
        Invoke("GetTired", Random.Range(10f, 20f));
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
