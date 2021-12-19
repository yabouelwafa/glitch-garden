using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
        StartCoroutine(waitTime());
        }
    }

    void Update()
    {
        
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(timeToWait);
        loadNextScene();
    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void RestartScene()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(currentSceneIndex);
    }

        public void LoadMainMenu()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("Start");
        
    }

    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("Options Screen");
        
    }


    public void loadGame()
    {
        SceneManager.LoadScene("level 1");
        
    }
    
    public void QuitGame()
    {
       Application.Quit();
    }
}
