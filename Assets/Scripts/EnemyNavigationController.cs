using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigationController : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent navMeshAgent;
    public NavMeshSurface navMeshSurface;

    void Start()
    {
        if (player == null)
        {
            print("Error: No player is assigned!");
        }
        navMeshAgent = transform.GetComponent<UnityEngine.AI.NavMeshAgent>();
        navMeshAgent.Warp(transform.position);
        navMeshSurface.BuildNavMesh();
    }

    void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }
}