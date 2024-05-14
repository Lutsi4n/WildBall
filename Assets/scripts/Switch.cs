using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public GameObject menuLvls;
    public GameObject pauseMenu;
    private Scene crtScene;
    private void Start() { crtScene = SceneManager.GetActiveScene(); }
    public void OpenLvlsMenu() { menuLvls.SetActive(true); }
    public void CloseLvlsMenu() { menuLvls.SetActive(false); }
    public void BackToMenu() { SceneManager.LoadScene(0); }
    public void Lvl1() { SceneManager.LoadScene(1); Time.timeScale = 1f; }
    public void Lvl2() { SceneManager.LoadScene(2); Time.timeScale = 1f; }
    public void Lvl3() { SceneManager.LoadScene(3); Time.timeScale = 1f; }
    public void Lvl4() { SceneManager.LoadScene(4); Time.timeScale = 1f; }
    public void Lvl5() { SceneManager.LoadScene(5); Time.timeScale = 1f; }
    public void UnPauseBtn() { pauseMenu.SetActive(false);  Time.timeScale = 1f; }
    public void PauseBtn() { Time.timeScale= 0; pauseMenu.SetActive(true); }
    public void ResetBtn() { SceneManager.LoadScene(crtScene.buildIndex); Time.timeScale = 1f; }

}
