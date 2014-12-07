using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int smallEnemyCount;

	// Use this for initialization
	void Start () {
		Transform enemyTarget = GameObject.Find("Planet").transform;

		for(int i = 0; i < smallEnemyCount; i+=1){
			Vector3 randomPosition = new Vector3(
					Random.Range(-30, 30),
					GameObject.Find("GamePlane").transform.position.y,
					Random.Range(-40, 40)
				);
			GameObject smallEnemy = (GameObject)Instantiate(Resources.Load("prefabs/smallEnemy"), randomPosition, gameObject.transform.rotation);
			smallEnemy.GetComponent<MoveTowards>().target  = enemyTarget;
			smallEnemy.GetComponent<LookAtTarget>().target = enemyTarget;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
