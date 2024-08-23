using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyPatrol script;
    public int maxHealth = 100;
    int currentHealth;
    public Animator animator;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 0){
            Die();
        }
    }

    public void Die(){

        animator.SetBool("Death", true);

        script.speed = 0;

        // GetComponent<Collider2D>().enabled = false;

        this.enabled = false;
    }


}
