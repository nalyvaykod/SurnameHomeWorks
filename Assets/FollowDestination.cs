using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowDestination : MonoBehaviour
{
    [SerializeField] private NavMeshAgent NavMeshAgentObject;
    public Transform destination;
    void Start()
    {
        NavMeshAgentObject = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        NavMeshAgentObject.SetDestination(destination.transform.position);  
    }
}
