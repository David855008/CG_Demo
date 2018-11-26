using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetect : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("test");
		anim.SetBool ("character_nearby", true);
	}
	void OnTriggerExit(Collider other)
	{
		anim.SetBool ("character_nearby", false);
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
