using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zuchinni : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] public float damage = 200f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();

        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
            
        }
    }

        

    
    
}

