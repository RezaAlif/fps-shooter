using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {
    public GameObject Zombie;
    float Timing;
    public float Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing > Target)
        {
            Timing = 0;
            Instantiate(Zombie, transform.position, transform.rotation);
        }
	}
}
