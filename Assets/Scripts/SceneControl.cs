using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    public void ChangeScene(int level) 
    {
        if (level == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if (level == 1)
        {
            SceneManager.LoadScene("LevelSelection" + level); ;
        }
        else if (level == 2)
        {
            SceneManager.LoadScene("1stScene" + level); ;
        }
        else if (level == 3)
        {
            SceneManager.LoadScene("2ndScene" + level); ;

        }
    }
}
