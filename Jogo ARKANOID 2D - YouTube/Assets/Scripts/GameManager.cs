using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int blocosNaFase;

    public AudioSource somDoBloco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarPartida();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    public void AdicionarBloco()
    {
        blocosNaFase += 1;
    }

    public void DescontarBloco()
    {
        blocosNaFase -= 1;
        somDoBloco.Play();

        if(blocosNaFase == 0)
        {
            PassarDeFase();
        }
    }

    public void PassarDeFase()
    {
        if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    private void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}
