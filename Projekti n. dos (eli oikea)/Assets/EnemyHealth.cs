using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public float enemyStartingHealth;
    public float enemyCurrentHealth;
    public static bool enemyDead;

    private void Awake()
    {
        enemyCurrentHealth = enemyStartingHealth;
    }
    public void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            enemyDead = true;
            Destroy (this.gameObject);
        }
    }
    public void EnemyTakeDamage(float _damage)
    {
        enemyCurrentHealth = Mathf.Clamp(enemyCurrentHealth - _damage, 0, enemyStartingHealth);
    }
}