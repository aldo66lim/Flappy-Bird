using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jp;
    public GameObject instucAnim;
    public GameObject gameoverAnim;
    public GameObject spawnPipe;
    public AudioSource hit;
    public AudioSource jump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            jump.Play();
            instucAnim.SetActive(false);
            spawnPipe.SetActive(true);
            rb.gravityScale = 2;
            rb.velocity = Vector2.up * jp;
        }
        
    }
  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            hit.Play();
            gameoverAnim.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
