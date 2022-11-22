using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;
    public static bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void Update()
    {
        if (currentHealth <= 0)
        {
            dead = true;
        }
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
    }
}
