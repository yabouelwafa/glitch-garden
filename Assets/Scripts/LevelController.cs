using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 4f;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject LoseLabel;
    public int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
        LoseLabel.SetActive(false);

    }
   
   public void AttackerSpawned()
   {
    //    numberOfAttackers = numberOfAttackers + 1;
   }


    public void AttackerKilled()
    {
       numberOfAttackers--;
       if(numberOfAttackers <= 0 && levelTimerFinished)
       {
           StartCoroutine(HandleWinConditions());
       }
    }

   IEnumerator HandleWinConditions()
   {
       winLabel.SetActive(true);
       GetComponent<AudioSource>().Play();
       yield return new WaitForSeconds(waitToLoad);
       FindObjectOfType<StartScreen>().loadNextScene();
   }

   public void HandleLoseConditions()
   {
       LoseLabel.SetActive(true);
   }

   public void LevelTimerFinished()
   {
       levelTimerFinished = true;
       StopSpawners();
   }

   private void StopSpawners()
   {
       AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
       foreach (AttackerSpawner spawner in spawnerArray)
       {
           spawner.StopSpawning();
       }
   }

   public void QuitGame()
   {
       Application.Quit();
   }

}
