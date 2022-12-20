using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAnimations : MonoBehaviour
{
    public Animator animator;
    public float timer = 1;

    void Start()
    {
        
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && timer <= 0)
        {
            animator.SetTrigger("Hit");
            timer = 1;
        }
    }
}
