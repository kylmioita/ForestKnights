using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damage;
    float lastdamaged = 1;
    public Animator animator;

    public void Update()
    {
        lastdamaged = lastdamaged - Time.deltaTime;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("DamageTrigger") && lastdamaged <= 0)
        {
            animator.SetBool("attack", true);
            this.gameObject.GetComponent<Health>().TakeDamage(damage);
            lastdamaged = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DamageTrigger"))
        {
            animator.SetBool("attack", false);
        }
    }

}
