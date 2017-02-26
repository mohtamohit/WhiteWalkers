using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour {

    public Text Timer;
    public float TimeLeft, StartTime;
    public float Health;
	// Use this for initialization
	void Start () {
        StartTime = Time.time; 
	}
	
	// Update is called once per frame
	void Update () {
      float t = Time.time - StartTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = ((int)(t % 60)).ToString();
        Timer.text =" Time : "+ minutes + " : " + seconds;
	}
}
