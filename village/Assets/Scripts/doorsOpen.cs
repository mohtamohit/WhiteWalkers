using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class doorsOpen : MonoBehaviour {
    public int doorsOpened;
    public Text doorCount;
	// Use this for initialization
	void Start () {
        doorsOpened = 0;
	}
	
	// Update is called once per frame
	void Update () {
        string s = doorsOpened.ToString();
        doorCount.text = "Doors Opened are : " + s;
        Debug.Log(doorsOpened);
	}
    void OnTriggerEnter(Collider collider)
    {
        doorsOpened++;
    }

    void OnTriggerExit(Collider collider)
    {
       
    }
}
