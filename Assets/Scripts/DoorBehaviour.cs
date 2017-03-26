using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour {

	RaycastHit hit;
	public GameObject camera;
	Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Physics.Raycast(camera.transform.position, camera.transform.forward * 2, out hit, 2f);
		Debug.DrawRay(camera.transform.position, camera.transform.forward * 2, Color.green, 1f);

		if (hit.transform.tag == "Door") {
			anim = hit.transform.GetComponent<Animator>();



			anim.SetBool("isOpen", true);


		}
	}
}
