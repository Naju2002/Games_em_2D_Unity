using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public string Jogo;
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Jogo);
    }

    void Update()
    {
        
    }
}
