using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public string Jogo;

    public GameObject infoIcon;
    public GameObject infoGame;
    public GameObject sairGame;

    private void Start()
    {
       // info = false;
    }
    public void StartInfo()
    {
        infoIcon.SetActive(true);
        sairGame.SetActive(false);
        infoGame.SetActive(false);
    }


    public void CloseInfo()
    {
        infoIcon.SetActive(false);
        sairGame.SetActive(true);
        infoGame.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Jogo);
    }

    public void CloseGame()
    {
        Application.Quit(); 
    }
    
}
