using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimplePlayerController : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;
    OffMeshLink link;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }
}
