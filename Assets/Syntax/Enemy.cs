using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Enemy : MonoBehaviour {
    GameManager Manager;
    public NavMeshAgent agent { get; private set; }
    public float speed;
    GameObject target;

    // Use this for initialization
    void Start () {
        Manager = GameObject.FindWithTag("Manager").GetComponent<GameManager>();
        agent = GetComponentInChildren<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
        agent.updateRotation = true;
        agent.speed = speed;
        agent.updatePosition = true;
    }
	
	// Update is called once per frame
	void Update () {
         if (target != null)
                agent.SetDestination(target.transform.position);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Peluru")
        {
            Manager.Score += 1;
            Destroy(gameObject);
        }
    }
}
