using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(transform.position, transform.forward * 1.5f, Color.cyan);
		if (Input.GetKeyDown(KeyCode.E)) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.forward, out hit, 1.5f)) {
				if (hit.transform.tag == "Interactable") {
					Debug.Log("Interaction! wololol!");

					if (hit.transform.GetComponent<ObjectInteractable>().isOpen == false) {
						hit.transform.GetComponent<ObjectInteractable>().Open();
					} else {
						hit.transform.GetComponent<ObjectInteractable>().Close();
					}
				}
			}
		}
	}
}
