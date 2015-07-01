using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour {

	public Score pointManager;

	// Use this for initialization
	void Start () {
		pointManager.score = 0;
	}

	void OnLevelWasLoaded(int level)
	{
		if (level == 0)
		{
			pointManager.score = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
