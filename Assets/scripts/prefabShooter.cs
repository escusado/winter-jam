using UnityEngine;
using System.Collections;
using InControl;

public class prefabShooter : MonoBehaviour {

	public float fireRate;
	public GameObject bulletPrefab;
	public Transform shootOrigin;
	
	private float nextFire;
	
	void Update () {
		var inputDevice = InputManager.ActiveDevice;
		
		if (inputDevice.RightTrigger > 0.0f && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(bulletPrefab, shootOrigin.position, shootOrigin.rotation);
			//			audio.Play();
		}
		
	}
}
