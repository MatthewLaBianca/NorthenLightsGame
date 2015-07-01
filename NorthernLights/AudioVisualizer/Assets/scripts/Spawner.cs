using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {


	public ChangeColor BassHit;
	public GameObject ObjectToBeSpawned;

	// Use this for initialization
	void Start () {
		//BassHit.bassHit = false;
	}
	
	// Update is called once per frame
	void Update () {
		CheckForBassHit(ObjectToBeSpawned);
		//Debug.Log(BassHit.bassHit);
	}

	void CheckForBassHit(GameObject ObjectSpawned)
	{
		if(BassHit.bassHit)
		{
			Instantiate(ObjectSpawned,new Vector3(0,0,0),Quaternion.identity);
		}
	}
}
