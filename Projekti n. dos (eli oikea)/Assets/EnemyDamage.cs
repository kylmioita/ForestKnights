using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float enemyDamage;
    public GameObject enemy;
    float enemyLastDamaged = 1;
    public void Update()
    {
        enemyLastDamaged = enemyLastDamaged - Time.deltaTime;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && enemyLastDamaged <= 0 && Input.GetButton("Fire1"))
        {
            enemy.gameObject.GetComponent<EnemyHealth>().EnemyTakeDamage(enemyDamage);
            enemyLastDamaged = 1;
        }
    }

}