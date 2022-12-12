using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 1f;
    private Rigidbody2D rig;

    public GameObject GameOver;

    public AudioSource som;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * velocidade;
            som.Play();
        }

        if (Input.GetKey("space"))
        {
            rig.velocity = Vector2.up * velocidade;
            som.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
