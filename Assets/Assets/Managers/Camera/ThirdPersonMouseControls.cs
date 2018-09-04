using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMouseControls : MonoBehaviour {

	public float sensitivity = 5f;

	public float rotationX = 0f;
	public float rotationY = 0f;
	public float keyRotationX = 0f;
	public float gunXOffest = 30f;

	private GameObject cameraArm;
	private Quaternion originRotation;
	private GameObject _gunBarrel;

	// Use this for initialization
	void Start () {
		originRotation = transform.localRotation;
		cameraArm = GameObject.FindGameObjectWithTag ("MainCamera");
		_gunBarrel = GameObject.FindGameObjectWithTag ("GunBarrel");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		rotationX += Input.GetAxis ("Mouse X") * sensitivity;
		rotationY += Input.GetAxis ("Mouse Y") * sensitivity;

		rotationY = Mathf.Clamp (rotationY, -45f, 45f);

		if(Input.GetButton("Horizontal")){
			keyRotationX += Input.GetAxis ("Horizontal") * sensitivity;

			rotationX += keyRotationX;

			rotationX = Mathf.Clamp (rotationX, -180, 180);

			if (rotationX == 180)
				rotationX = -179;

			if (rotationX == -180)
				rotationX = 179;

			keyRotationX = 0;
		}

		Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
		Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, -Vector3.right);

		Quaternion yQuaternionGunBarrel = Quaternion.AngleAxis (rotationY, -Vector3.right);
		Quaternion xQuaternionGunBarrel = Quaternion.AngleAxis (gunXOffest, -Vector3.up);

		cameraArm.transform.localRotation = yQuaternion;
		_gunBarrel.transform.localRotation = yQuaternionGunBarrel * xQuaternionGunBarrel;

		transform.localRotation = originRotation * xQuaternion;


		float cameraYHeight = Mathf.Clamp ((-rotationY / 50)+1.2f, 0.6f, 1.8f);
		cameraArm.transform.localPosition = new Vector3(cameraArm.transform.localPosition.x, cameraYHeight, cameraArm.transform.localPosition.z);
	}
}
