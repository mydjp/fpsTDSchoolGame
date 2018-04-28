using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
		public int beer = 0;
		public int bacon = 9;
	// Use this for initialization
	void Start () {

		// for	(int i=99;i > beer; i--) {
		// 	print(i + " bottles of beer on the wall!");
		// }

		// while(bacon >=1){
		// 	print("Mmmm bacon!! !"+ bacon);

		// 	bacon --;
		// }
		// if(bacon <= 0){
		// 	print("Damn out of bacon!!");
		// }

		string[] churro = new string[3];

		churro[0] = "First churro, Yum";
		churro[1] = "Second Churro,eh!";
		churro[2] = "Third Churro, Yuck";

		foreach(string item in churro){
			print(item);
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
