using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float health = 200f;
    [SerializeField] GameObject deathVFX;

    

   public void DealDamage(float damage)
   {
       health -= damage;
       if (health <= 0)
       {
           Destroy(gameObject);
           TriggerDeathVFX();
           var scoreClass = FindObjectOfType<ScoreDisplay>();
           scoreClass.AddScore();
       }
   }

    private void TriggerDeathVFX()
    {
        if(!deathVFX) {return;}
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
    }

}
