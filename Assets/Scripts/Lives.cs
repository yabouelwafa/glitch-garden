using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lives : MonoBehaviour
{

    [SerializeField] int lives = 5;
    Text liveDisplay;

    void Start()
    {
        liveDisplay = GetComponent<Text>();
    }

    void Update()
    {
      liveDisplay.text = lives.ToString();  
      if (lives == 0)
      {
          FindObjectOfType<LevelController>().HandleLoseConditions();
      }
    }

    public void UpdateLives()
    {
        lives = lives - 1;
    }
}
