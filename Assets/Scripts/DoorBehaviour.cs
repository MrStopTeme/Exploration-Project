using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour {

	public RaycastHit hit;
	public GameObject camera;
	public Animator anim;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Physics.Raycast(camera.transform.position, camera.transform.forward * 1.5f, out hit, 1.5f);
		Debug.DrawRay(camera.transform.position, camera.transform.forward * 1.5f, Color.green);

		if (hit.transform.tag == "Door") {
			anim = hit.collider.GetComponentInParent<Animator>();

			if (Input.GetKeyDown(KeyCode.E)) {
				anim.SetBool("Open", !anim.GetBool("Open"));
			}
		}
	}
}
