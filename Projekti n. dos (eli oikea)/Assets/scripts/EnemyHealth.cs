using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public float enemyStartingHealth;
    public float enemyCurrentHealth;
    public static bool enemyDead;
    public Animator animator;
    private float timer = 1;
    private bool timerOn;

    private void Awake()
    {
        enemyCurrentHealth = enemyStartingHealth;
    }
    public void Update()
    {
        Debug.Log(timer);
        if (timerOn == true)
        {
            timer = timer - Time.deltaTime;
        }

        if (timer <= 0)
        {
            animator.SetBool("hit", false);
            timer = 1;
        }

        if (enemyCurrentHealth <= 0)
        {
            enemyDead = true;
            Score.score++;
            Destroy (this.gameObject);
        }
    }
    public void EnemyTakeDamage(float _damage)
    {
        animator.SetBool("hit", true);
        enemyCurrentHealth = Mathf.Clamp(enemyCurrentHealth - _damage, 0, enemyStartingHealth);
        timerOn = true;
    }
}