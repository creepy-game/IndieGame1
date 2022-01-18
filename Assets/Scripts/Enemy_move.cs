using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy_move : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追いかける対象")]
    private GameObject player;

    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        // NavMeshAgentを保持しておく
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = player.transform.position;
    }
}