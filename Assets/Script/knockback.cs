using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float thrust;
    public float knockTime;
    public float damage;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
         if (other.gameObject.CompareTag("breakable") && this.gameObject.CompareTag("Player") )
        {
            other.GetComponent<pot>().Smash();
        }
        if (other.gameObject.CompareTag("enemy") || other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D hit = other.GetComponent<Rigidbody2D>();
            if(hit != null)
            {
                Vector2 difference = hit.transform.position - transform.position;
                difference = difference.normalized * thrust;
                hit.AddForce(difference, ForceMode2D.Impulse);

                if(other.gameObject.CompareTag("enemy") && other.isTrigger){
                    hit.GetComponent<Ennemy>().currentState  =EnemyState.stagger;
                    other.GetComponent<Ennemy>().Knock(hit, knockTime, damage);
                }
                if(other.gameObject.CompareTag("Player")){
                    if(other.GetComponent<PlayerMouvement>().currentState != PlayerState.stagger){
                        hit.GetComponent<PlayerMouvement>().currentState = PlayerState.stagger;
                        other.GetComponent<PlayerMouvement>().Knock(knockTime, damage);
                    }
                }
                
              
            }
        }
    }

   

}