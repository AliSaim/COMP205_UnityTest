using UnityEngine;
using System.Collections;

//reference to the UI namespace
using UnityEngine.UI;


//reference to manage my scences
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//private INSTANCE VARIBALES
	private int _livesValue;
	private int _scoreValue;


	// PUBLIC INSTANCE VARIABLES
	public int enemyCount;
	public GameObject enemy;


	[Header("UI Objects")]
	public Text LivesLabel;
	public Text ScoreLabel;



	//public properties+++++++++++++++
	public int LiveValue
	{
		get{return this._livesValue; }

		set{this._livesValue = value; }
	}

	public int ScoreValue
	{
		get{ return this._scoreValue;}
		set{ this._scoreValue = value;}
	}

	
	// Use this for initialization
	void Start () {
		this.LiveValue = 5;
		this.ScoreValue = 0;
		this._GenerateEnemies ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Clouds
	private void _GenerateEnemies() {
		for (int count=0; count < this.enemyCount; count++) {
			Instantiate(enemy);
		}
	}
}
