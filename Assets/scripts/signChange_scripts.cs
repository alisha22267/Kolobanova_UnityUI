using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class signChange_scripts : MonoBehaviour
{
    public void ToUIScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ToMainMenue()
    {
        SceneManager.LoadScene("menue", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
