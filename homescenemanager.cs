using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class homescenemanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void nextscene()
	{
		SceneManager.LoadScene ("2nd UI");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
