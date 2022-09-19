using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform playerPos;
    NavMeshAgent agent;
    public float stopDistantion;
    public float retritDistantion;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if(Vector2.Distance(transform.position,playerPos.position) > stopDistantion )
        {
            agent.SetDestination(playerPos.position);
        }else if(Vector2.Distance(transform.position,playerPos.position) < stopDistantion)
        {
            transform.position = this.transform.position;
        }
        
    }
}
