using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public void ChangeLevel(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
