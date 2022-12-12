using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    private void Start()
    {
        controller = FindObjectOfType<GameController>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        controller.score++;
        controller.scoreText.text = controller.score.ToString();

        controller.scoreA++;
        controller.scoreTextA.text = controller.scoreA.ToString();

    }
}
