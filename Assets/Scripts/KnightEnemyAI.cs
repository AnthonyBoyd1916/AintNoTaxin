using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KnightEnemyAI : MonoBehaviour
{
    [SerializeField] private Transform playpos;
    [SerializeField] private Transform enemypos;
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;        
    }

    private void Update()
    {
        agent.SetDestination(playpos.position);
    }
}
