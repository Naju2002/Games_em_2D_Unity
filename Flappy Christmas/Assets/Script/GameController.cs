using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public int scoreA;
    public Text scoreTextA;

    public string cena;
    public string jogo;

    public AudioSource som;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void ReproduzirSom()
    {
        som.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(jogo);
    }

    public void ProxCena()
    {
        
        SceneManager.LoadScene(cena);
    }
}
