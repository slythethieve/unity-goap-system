using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject patientPrefab;
    public int numOfPatients;
    public bool keepSpwaning = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numOfPatients; i++)
        {
            Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        }
        if (keepSpwaning)
            Invoke("SpawnPatients", 5f);
    }

    void SpawnPatients()
    {
        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        Invoke("SpawnPatients", Random.Range(25f,30f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
