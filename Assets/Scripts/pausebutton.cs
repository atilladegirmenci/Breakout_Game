using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausebutton : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    public void PauseButton()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    public void resumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void SelectLevelButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("main menu");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
