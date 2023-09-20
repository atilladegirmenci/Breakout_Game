using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplatescene : MonoBehaviour
{
    public void L1() { SceneManager.LoadScene("Level1"); }

    public void L2() { SceneManager.LoadScene("Level2"); }
    public void L3() { SceneManager.LoadScene("Level3"); }
    public void QuitGame() { Application.Quit(); }

}
