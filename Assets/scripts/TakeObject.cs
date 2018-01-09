using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObject : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("Jump")) {
			obj.transform.position = new Vector3 (544.51f, 206.45f, 17.43f);
		}
	}
}
