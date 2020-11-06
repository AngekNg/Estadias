using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
public class GameController : MonoBehaviour
{
    public Text gameOverText;
    PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
    GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
    Player = playerObj.GetComponent<PlayerController>();

    }
    
    // Update is called once per frame
    void Update()
    {

    }
    public void gameOver()
    {
        gameOverText.enabled = true;
        StartCoroutine(gameOverProcess());
    }
    IEnumerator gameOverProcess()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("LevelSelection");
    }
}
