using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 6f;
    
    void Start()
    {
        float r = Random.Range(2.56f, -1.26f);
        transform.position = new Vector2(transform.position.x, r);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left*1000, Time.deltaTime * speed);
    }
}
