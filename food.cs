using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {
	public GameObject foods;
	public float xMax, xMin, yMax, yMin;


	// Use this for initialization
	void Start () {
		for (int i = 0; i < 5; i++) {
			float p = Random.Range (xMin,xMax);
			float q = Random.Range (yMin,yMax);
			Vector2 position= new Vector2 (p,q);
			Instantiate (foods,position,Quaternion.identity);
		}
	}
	void OnTriggerEnter(Collider other)
	{

		Destroy (other.gameObject);
		//score++;
		//print ("score :" + score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
