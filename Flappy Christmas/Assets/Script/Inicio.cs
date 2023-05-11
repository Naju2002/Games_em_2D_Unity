using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public string Jogo;

    public AudioSource som;

    public GameObject infoIcon;
    public GameObject infoGame;
    public GameObject sairGame;
    public GameObject playGame;


    public void ReproduzirSom()
    {
        som.Play();
    }

    public void StartInfo()
    {
        infoIcon.SetActive(true);
        sairGame.SetActive(false);
        infoGame.SetActive(false);
        playGame.SetActive(false);
    }


    public void CloseInfo()
    {
        infoIcon.SetActive(false);
        sairGame.SetActive(true);
        infoGame.SetActive(true);        
        playGame.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene (Jogo);
        //StartCoroutine("jogar");
    }

    /*private IEnumerator jogar()
    {
        yield return new WaitForSeconds (0.2f);
        SceneManager.LoadScene (Jogo);
    }*/

    public void CloseGame()
    {
        Application.Quit(); 
    }
    
}
