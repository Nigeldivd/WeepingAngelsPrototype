using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    [SerializeField] private bool inView;
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform player;
    //private Animation anim;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animation>();
    }

    void Update()
    {
        if (!inView)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }

    private void OnBecameVisible()
    {
        inView = true;
        navMeshAgent.velocity = new Vector3(0, 0, 0);
        navMeshAgent.ResetPath();
        //anim.enabled = false;
    }

    private void OnBecameInvisible()
    {
        inView = false;
        //anim.enabled = true;
    }
}
