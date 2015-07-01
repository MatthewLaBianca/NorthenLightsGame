using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(score);
	}
}
