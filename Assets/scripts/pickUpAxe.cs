using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpAxe : MonoBehaviour {
	public GameObject Axe;
	public GameObject DecorateAxe;
	public bool OnZonaAxe = false;
	public Collider ZonaAxe;
	public GameObject ScreemerFirst;
	public GameObject Door;
	// Use this for initialization
	void Start () {
		Axe.SetActive (false);
		ScreemerFirst.SetActive (false);
	}
	public void OnTriggerEnter(Collider ZonaAxe){
		OnZonaAxe = true;
	}
	
	// Update is called once per frame
	void Update () {
		Door.transform.Rotate (new Vector3 (0f, 0f, 0f));
	}
	public void OnMouseDown(){
		if (OnZonaAxe == false) {
			OnZonaAxe = true;
		} else {
			OnZonaAxe = false;
			Destroy (DecorateAxe);
			Axe.SetActive (true);
			ScreemerFirst.SetActive (true);
			Door.transform.Rotate (new Vector3 (0f, +150f, 0f));
		}
	}
}
