using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ufomove : MonoBehaviour {
	public float Speed;
	private Rigidbody2D rb;
	public GameObject foods;
	public float xMax, xMin, yMax, yMin;
	public int score;
	public int scene;
	//public int time;
	public float totaltime;
	public Text WinText;
	public Text ScoreText;
	public Text TimeText;
	// Use this for initialization
	void Start () {

		scene = 0;
		score = 0;
		totaltime = 20;
		rb = GetComponent<Rigidbody2D> ();
		for (int i = 0; i < 5; i++) {
			float p = Random.Range (xMin,xMax);
			float q = Random.Range (yMin,yMax);
			Vector2 position= new Vector2 (p,q);
			Instantiate (foods,position,Quaternion.identity);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{

		Destroy (other.gameObject);
		score++;
		//print ("score :" + score);
	}
	/*public void nextscene()
	{
		if (scene == 1) {
			SceneManager.LoadScene ("3rd UI");
		}

	}*/
	// Update is called once per frame
	void Update () {
		totaltime -= Time.deltaTime;
		if (totaltime > 0f) {
			if (score >= 5) {
				WinText.text = "You Win";
				scene = 1;
				if (scene == 1) {
					SceneManager.LoadScene ("3rd UI");
				}
			} else if (score < 5) {
				float moveHorizontal = Input.GetAxis ("Horizontal");
				float moveVertical = Input.GetAxis ("Vertical");
				Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
				rb.AddForce (movement * Speed);
				ScoreText.text = "score :" + score;
				//ScoreText.text = score.ToString ();
				int time = (int)totaltime;
				TimeText.text = "Time :" + time;
			}
			
		} else if (totaltime <= 0f) {
			if (score < 5) {
				WinText.text = "You loose";
			}
		}

		
	}
}
