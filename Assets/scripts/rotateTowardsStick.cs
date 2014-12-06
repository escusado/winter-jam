using UnityEngine;
using System.Collections;
using InControl;


public class rotateTowardsStick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var inputDevice = InputManager.ActiveDevice;

		float rightStickX = inputDevice.RightStickX;
		float rightStickY = inputDevice.RightStickY;

		float yAngle = Mathf.Atan2(-rightStickX, rightStickY) * 180 / Mathf.PI;

		if(yAngle == 0){
			return;
		}

		transform.eulerAngles = new Vector3( 0, yAngle , 0 );
	}
}
