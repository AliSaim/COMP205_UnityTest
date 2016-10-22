using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	public GameController gameController;


	//do something
	protected void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("hello!");
	}

}
