using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public string Jogo;

    public bool info;

    public GameObject infoIcon;

    private void Start()
    {
       // info = false;
    }
    public void StartInfo()
    {
        infoIcon.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Jogo);
    }

    
}
