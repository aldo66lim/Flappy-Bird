using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipeSpawn;
    public float timeSpawn = 1.5f;
    private float time = 0;


    private void Update()
    {
        if (time <= 0)
        {
            Instantiate(pipeSpawn, transform.position, Quaternion.identity);
            time = timeSpawn;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
    
}
