using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySenses : MonoBehaviour
{
    public float LookRadius = 5000;

    Transform target;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = PlayerManager.instance.Player.transform;
        GetComponent<NavMeshAgent>().speed = 30;
    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, target.position);

        if (distance <= LookRadius)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
