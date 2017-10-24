using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class littleStar2 : MonoBehaviour {

	public float stime, ctime, time;
	Button bu1,bu2,bu3,bu4,bu5,bu6;
	public static float speed,drag;
	private GameObject start1,start2,great,sad;
	public static double score;
	public static int alevel = 1,clevel;




	// Use this for initialization
	void Start () {
		time = 0;
		Time.timeScale = 0;
		score = 0;
//		speed = 1.0f;
//		//0.7//0.47
//		drag = 7;
//		//5//3
		start1=GameObject.Find("Start");
		start2 = GameObject.Find ("start");
		great = GameObject.Find ("great");
		sad = GameObject.Find ("sad");


		start1.GetComponent<Button>().onClick.AddListener(clickstart);





		GameObject.Find ("Button").GetComponent<Button> ().onClick.AddListener (checkLittleStar1);
		GameObject.Find ("Button (1)").GetComponent<Button> ().onClick.AddListener (checkLittleStar2);
		GameObject.Find ("Button (2)").GetComponent<Button> ().onClick.AddListener (checkLittleStar3);
		GameObject.Find ("Button (3)").GetComponent<Button> ().onClick.AddListener (checkLittleStar4);
		GameObject.Find ("Button (4)").GetComponent<Button> ().onClick.AddListener (checkLittleStar5);
		GameObject.Find ("Button (5)").GetComponent<Button> ().onClick.AddListener (checkLittleStar6);

		GameObject.Find ("star1").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star2").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star3").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star4").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star5").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star6").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star7").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star8").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star9").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star10").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star11").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star12").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star13").GetComponent<Rigidbody>().drag=drag;
		GameObject.Find ("star14").GetComponent<Rigidbody>().drag=drag;

	}

	// Update is called once per frame
	void Update () {
		ctime = Time.time;
		time = ctime - stime;

		if (time > 18 * speed){
			Application.LoadLevel ("Score");
		}
	}

	void clickstart(){

		start1.SetActive (false);
		start2.SetActive (false);
		sad.SetActive(false);
		great.SetActive(false);
		Time.timeScale = 1;
		stime = Time.time;



	}
	void checkLittleStar1(){
		if (time > 3.2 * speed && time < 4.2 * speed) {
//			great.SetActive(true);

			score += 100.0 / 14;
			Debug.Log ("great do 1");
		} else {
		
//			sad.SetActive(true);

		}
		if (time > 4.2 * speed && time < 5.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;

			Debug.Log ("great do 2");
		} else {
		
//			sad.SetActive (true);
		}
		if (time > 17.2 * speed && time < 18.2 * speed) {
			score += 100.0 / 14;
//			great.SetActive (true);
			Debug.Log ("great do 3");
		}


	}

	void checkLittleStar5(){
		if (time > 5.2 * speed && time < 6.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 4");
		} else {
		
//			sad.SetActive (true);

		}
		if (time > 6.2 * speed && time < 7.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 5");
		} else {
		
//			sad.SetActive (true);

		}
		if (time > 9.2 * speed && time < 10.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 6");
		} else {
//			sad.SetActive (true);
		}


	}

	void checkLittleStar6(){
		if (time > 7.2 * speed && time < 8.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 7");
		} else {
//			sad.SetActive (true);
		}
		if (time > 8.2 * speed && time < 9.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 8");
		} else {
		
//			sad.SetActive (true);
		}

	}

	void checkLittleStar4(){
		if (time > 11.2 * speed && time < 12.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 9");
		} 
//			sad.SetActive (true);
		if (time > 12.2 * speed && time < 13.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 10");
		} 
//			sad.SetActive (true);

	}

	void checkLittleStar3(){
		if (time > 13.2 * speed && time < 14.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 11");
		}
//			sad.SetActive (true);
		if (time > 14.2 * speed && time < 15.2 * speed) {
//			great.SetActive (true);
			score += 100.0 / 14;
			Debug.Log ("great do 12");
		} 
//			sad.SetActive (true);

	}

	void checkLittleStar2(){
		if (time > 15.2 * speed && time < 16.2 * speed) {
			score += 100.0 / 14;
			Debug.Log ("great do 13");
//			great.SetActive (true);
		} 
//			sad.SetActive (true);;
		if (time > 16.2 * speed && time < 17.2 * speed) {
			score += 100.0 / 14;
			Debug.Log ("great do 14");
//			great.SetActive (true);
		}
//			sad.SetActive (true);

	}



}
