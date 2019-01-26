using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject Kamera;
    public GameObject Result;
    public GameObject PlayerUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(gameObject);
            PlayerUI.SetActive(false);
            Kamera.SetActive(true);
            Result.SetActive(true);
        }
    }
}
