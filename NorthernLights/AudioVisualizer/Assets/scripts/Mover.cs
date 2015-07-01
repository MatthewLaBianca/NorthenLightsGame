using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mover : MonoBehaviour {


	public AudioSource clicked;

	public bool fullPoints;

	private int numberPass;



	// Use this for initialization
	void Start () {
		numberPass = 0;
		//pointManager.score = 0;
		fullPoints = false;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position -= new Vector3(0,0.6f,0);

		Debug.Log(GameObject.Find("GameManager").GetComponent<Score>().score);
		//Debug.Log(fullPoints);
	}

	void OnMouseDown()
	{
		//Destroy(gameObject);
		//clicked.Play();
		if(fullPoints)
		{
			Debug.Log("FULL POINTS");
			GameObject.Find("GameManager").GetComponent<Score>().score += 500;
			this.GetComponent<Renderer>().enabled = false;
		}
		else if(!fullPoints && numberPass == 3)
		{
			Debug.Log("no points");
			GameObject.Find("GameManager").GetComponent<Score>().score += 100;
			this.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			Debug.Log("no points");
			GameObject.Find("GameManager").GetComponent<Score>().score += 10;
			this.GetComponent<Renderer>().enabled = false;
		}
	}

	void OnTriggerEnter(Collider trigger)
	{
		if(trigger.gameObject.tag == "Destroyer")
		{
			GameObject.Find("GameManager").GetComponent<Score>().score += 10;
			Destroy(gameObject);
		}
		if(trigger.gameObject.tag == "checkInside")
		{
			numberPass = 2;
			fullPoints = true;
			
		}
		if(trigger.gameObject.tag == "checkTooFar")
		{
			numberPass = 3;
			fullPoints = false;
		}
		if(trigger.gameObject.tag == "checkTooHigh")
		{
			numberPass = 1;
			fullPoints = false;
		}
	}
	
}
