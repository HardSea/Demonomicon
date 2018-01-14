using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
	public bool IsActive = false;
	public bool OnZona = false;
	public Collider Zona;
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	public void OnTriggerEnter(Collider Zona){
		OnZona = true;
	}
	void Update () {
		
	}
	public void OnMouseDown(){
			if (IsActive == false && OnZona == false) {
			transform.Rotate (new Vector3 (0f, -150f, 0f));
			IsActive = true;
			OnZona = true;
		} else {
			transform.Rotate (new Vector3 (0f, +150f, 0f));
			IsActive = false;
			OnZona = false;
		}
}
}
