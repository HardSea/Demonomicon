using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class controller : MonoBehaviour {
	Vector3 position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		position = new Vector3 (0f,CnInputManager.GetAxis ("Horizontal"),CnInputManager.GetAxis ("Vertical"));
		transform.position += position * Time.deltaTime * 10;
		Debug.Log (position);
	}
}
