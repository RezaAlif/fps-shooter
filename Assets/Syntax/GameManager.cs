using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int Score;
    float Timing = 60;
    public GameObject Results;
    public GameObject Player;
    public GameObject Kamera;
    public GameObject PlayerUI;
    public Text Skor;
    public Text Waktos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Skor.text = "Score : " + Score.ToString();
        Waktos.text = Timing.ToString("F0");
        Timing -= Time.deltaTime;
        Waktu();
	}

    void Waktu()
    {
        if(Timing < 0)
        {
            Destroy(Player);
            Kamera.SetActive(true);
            Results.SetActive(true);
            PlayerUI.SetActive(false);
        }
    }
}
