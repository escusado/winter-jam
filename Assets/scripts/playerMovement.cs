using UnityEngine;
using System.Collections;
using InControl;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class playerMovement : MonoBehaviour {

	public float speed;
	public Boundary boundary;

	private float prevX;
	private float prevY;
	private Vector3 currentMovement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		var inputDevice = InputManager.ActiveDevice;
		
		float moveHorizontal = inputDevice.LeftStickX;
		float moveVertical   = inputDevice.LeftStickY;

		Debug.Log(">>>>" + moveVertical + "-" + moveHorizontal);

		currentMovement =  new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidbody.velocity = currentMovement * speed;
		
		rigidbody.position = new Vector3(
			Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
			0, 
			Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
			);
	}
}
