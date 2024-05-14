using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plrWinLoseControl : MonoBehaviour
{
    private Scene crtScene;
    public GameObject hintE;
    public GameObject WallToMove;
    public GameObject bonus;
    public GameObject ball;
    public ParticleSystem particlesBonus;
    public ParticleSystem particleDeath;

    void Start()
    {
        crtScene= SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (hintE.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (WallToMove.activeInHierarchy == true)
                    WallToMove.SetActive(false);
                else
                    WallToMove.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTr"))
            Death();

        if (other.CompareTag("WinZone"))
            if (crtScene.buildIndex < 5)
                SceneManager.LoadScene(crtScene.buildIndex + 1);
            else
                SceneManager.LoadScene(0);
        if (other.CompareTag("hint")) 
            hintE.SetActive(true);

        if (other.CompareTag("bonus")) 
        {
            particlesBonus.Play();
            var main = particlesBonus.main;
            Destroy(bonus, main.duration);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hint")) 
            hintE.SetActive(false);
    }

    private void Death()
    {
        particleDeath.Play();
        var mainv2 = particleDeath.main;
        Destroy(ball, mainv2.duration);
    }
}
