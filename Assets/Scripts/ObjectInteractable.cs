using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractable : MonoBehaviour, IInteractable{
	public bool isOpen;
	public string Type;

	void Start () {
		isOpen = false;
	}

	public void Open () {
		switch (Type) {
			case "Door": {
				Debug.Log("door!");
				break;
			}
		}
	}

	public void Close () {

	}
}
