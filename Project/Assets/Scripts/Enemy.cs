using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform Player;
    bool chase;
<<<<<<< Updated upstream:Project/Assets/Scripts/Enemy.cs
    public float timer = 0;
    bool timerOn = false;
=======
    public float timer = 5;
    bool timerOn;
>>>>>>> Stashed changes:Project/Assets/Enemy.cs

    void Start()
    {
        Move();
    }


    void Update()
    {
        Debug.Log(enemy.destination);
        if (chase == true)
        {
            enemy.SetDestination(Player.position);
<<<<<<< Updated upstream:Project/Assets/Scripts/Enemy.cs
            enemy.speed = 5f;
=======
            enemy.speed = 10f;
        }

        if (timerOn == true)
        {
            timer = timer - Time.deltaTime;
        }

        if (timer < 0)
        {
            chase = false; 
            Move();
>>>>>>> Stashed changes:Project/Assets/Enemy.cs
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
            timerOn = false;
            chase = true;
            timer = 5;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && timer >= 5)
        {
<<<<<<< Updated upstream:Project/Assets/Scripts/Enemy.cs
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
=======
            timerOn = true;
            chase = true;
            enemy.speed = 5f;
>>>>>>> Stashed changes:Project/Assets/Enemy.cs
        }
    }
}
