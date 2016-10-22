
/*Student Name: Ali Saim
 * Student Number: 300759480
 * Course: COMP 305- Section: (Combined)
 * Program Name: Gamee Programming 1
 * Date last Modified: October 22, 2016 
 * 
 * */


using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	public GameController gameController;


	//do something
	protected void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("hello!");
	}

}
