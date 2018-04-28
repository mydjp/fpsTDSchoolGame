using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour {

	public static int score;

	public int winScore;
	public Text text;

	public Text winText;


	// Use this for initialization
	void Awake() {
		Time.timeScale = 1;
		
	}
	
	// Update is called once per frame
	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
		score = 0;
	}

	void Update () {
		if (score < 0)
		score = 0;
		 text.text =" "+ score;

		 if(winScore == score ){
			 print("Wint Score Reached = " + score);
			 winText.GetComponent<Text>().enabled = true;
			 Time.timeScale = 0;
	
		 }

		 if (Input.GetKeyDown(KeyCode.Escape)){
			 SceneManager.LoadScene(0);
		 }
	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public void Reset(){
		score=0;
	}
}
