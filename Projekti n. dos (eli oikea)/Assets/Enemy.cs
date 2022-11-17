using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform Player;
    bool chase;
    public float timer = 5;
    bool timerOn;

    void Start()
    {
        Move();
    }


    void Update()
    {
        Debug.Log(timer);
        if (chase == true)
        {
            enemy.SetDestination(Player.position);
            enemy.speed = 10f;
        }
        if (timerOn == true)
        {
            timer = timer - Time.deltaTime;
        }
        if (timer > 0)
        {
            chase = true;
        }
        if (timer <= 0)
        {           
            chase = false;
        }

    }

    public Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        UnityEngine.AI.NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }

    void Move()
    {
        enemy.SetDestination(RandomNavmeshLocation(100f));
        Invoke("Move", 5f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timerOn = false;
            chase = true;
            timer = 5;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timerOn = true;
            chase = false;
            Move();
            enemy.speed = 5f;
        }
    }
}