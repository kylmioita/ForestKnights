using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform Player;
    bool chase;
    public float timer = 0;
    bool timerOn = false;

    void Start()
    {
        Move();
    }


    void Update()
    {
        if (chase == true)
        {
            enemy.SetDestination(Player.position);
            enemy.speed = 5f;
        }
        if (timerOn == true)
        {
        timer += Time.deltaTime;
        Debug.Log(timer);
        }
        Debug.Log(timer);

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
            chase = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && timer >= 5)
        {
            timerOn = false;
            chase = false;
            Move();
            enemy.speed = 5f;
        }
        if (other.CompareTag("Player") && timer <= 5)
        {
            timerOn = true;
            chase = true;
            timer = 0;
        }
    }
}
