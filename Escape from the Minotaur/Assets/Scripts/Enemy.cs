using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    private NavMeshAgent myAgent;
    private Animator myAnimator;
    private float dist;
    public Transform player;
    public float radius;


    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
    }


    private void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > 150)
        {
            myAgent.enabled = false;

        }
        if (dist < 150 && dist > radius)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(player.transform.position);
            transform.LookAt(player);
            myAnimator.SetBool("runBool", true);
            myAnimator.SetBool("attakBool", false);

        }
        if (dist < radius)
        {
            transform.LookAt(player);
            myAgent.enabled = false;
            myAnimator.SetBool("attakBool", true);
            myAnimator.SetBool("runBool", false);
        }
    }
}
