using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LookAt : MonoBehaviour {

	Camera mainCamera;
	GameObject HUD;
	Slider slider;

	public delegate void OnLayerChange();
	public OnLayerChange layerChangeObservers;
	public GameObject focusedObject;
	public Vector3 lookDirection;
	public Vector3 lookPoint;

	private GameObject gunBarrel;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
		gunBarrel = GameObject.FindGameObjectWithTag ("GunBarrel");

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = mainCamera.ViewportPointToRay (new Vector3(0.5f, 0.5f, 0f));

		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.tag == "Enemy") {
				focusedObject = hit.transform.gameObject;
			} else {
				focusedObject = null;
			}
		}

		lookDirection = (hit.point - gunBarrel.transform.position);
	}
}
