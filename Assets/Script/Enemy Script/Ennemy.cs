using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public enum EnemyState{
    idle,
    walk,
    attack,
    stagger
}

public class Ennemy : MonoBehaviour
{

    [Header("State machine")]
    public EnemyState currentState;

    [Header("Enemy stats")]
    public FloatValue maxHealth;
    public float health;
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;

    [Header("Death effect")]
    public GameObject deathEffect;
    private float deathEffectDelay = 1f;
   
    private void Awake(){
        health = maxHealth.initialValue;
    }

    private void TakeDamage(float damage){
        health -= damage;
        if(health <= 0){
            DeathEffect();
            this.gameObject.SetActive(false);

        }
    }
    private  void DeathEffect(){
        if(deathEffect != null){
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, deathEffectDelay);
        }
    }

    public void Knock(Rigidbody2D myRigidbody, float knockTime, float damage){
        StartCoroutine(KnockCo(myRigidbody, knockTime));
        TakeDamage(damage);
    }

    private IEnumerator KnockCo(Rigidbody2D myRigidbody, float knockTime)
    {
        if(myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = EnemyState.idle;
            myRigidbody.velocity = Vector2.zero;
        }

    }

}
