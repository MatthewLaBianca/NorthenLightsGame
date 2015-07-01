using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public Material cubeMaterial;

	public bool bassHit;


	public GameObject objectBeingSpawned;
	//private int currentColor;




	// Use this for initialization
	void Start () {
		//cubeMaterial.color = Color.green;
		//bassHit = false;
		cubeMaterial.color = Color.green;
		//currentColor = ColorStates.green;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(bassHit);
	

	}




	void OnTriggerEnter(Collider trigger)
	{
		//bassHit = true;
		if(trigger.gameObject.tag == "colorChanger" && cubeMaterial.color == Color.green)
		{
			cubeMaterial.color = Color.blue;
			//cubeMaterial.color = Color.Lerp(Color.green,Color.blue, Time.deltaTime * 20);
		}
		else if(trigger.gameObject.tag == "colorChanger" && cubeMaterial.color == Color.blue)
		{
			cubeMaterial.color = Color.red;
			//cubeMaterial.color = Color.Lerp(Color.blue,Color.red, Time.deltaTime * 20);
		}
		else if(trigger.gameObject.tag == "colorChanger" && cubeMaterial.color == Color.red)
		{
			cubeMaterial.color = Color.white;
			//cubeMaterial.color = Color.Lerp(Color.red, Color.white, Time.deltaTime * 20);
		}
		else if(trigger.gameObject.tag == "colorChanger" && cubeMaterial.color == Color.white)
		{
			cubeMaterial.color = Color.green;
			//cubeMaterial.color = Color.Lerp(Color.white, Color.green, Time.deltaTime * 20);
		}

		SpawnObject(objectBeingSpawned);
	}


	void SpawnObject(GameObject SpawnedObject)
	{
		Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

		Instantiate(SpawnedObject,new Vector3(0,Screen.height/ Screen.height * 12,Random.Range(-32, -1)),Quaternion.identity);
	}

	void OnTriggerExit(Collider trigger)
	{
		if(trigger.gameObject.tag == "colorChanger")
		{
			//Debug.Log("not hit");
			//bassHit = false;
		}
	}

}
