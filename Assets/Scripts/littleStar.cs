using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class littleStar : MonoBehaviour {

	public float stime, ctime, time;
	Button bu1,bu2,bu3,bu4,bu5,bu6;
	public static float speed;
	private GameObject start1,start2,great,sad;
	public static double score;
	public static int alevel = 1,clevel=1;
	public float time1, time2;
	public int stay;

	Transform trans1,trans2,trans3,trans4,trans5,trans6,trans7;
	Transform trans8,trans9,trans10,trans11,trans12,trans13,trans14;
	bool s1=true,s2=true,s3=true,s4=true,s5=true,s6=true,s7=true,
	s8=true,s9=true,s10=true,s11=true,s12=true,s13=true,s14=true;




	// Use this for initialization
	void Start () {
		
		Time.timeScale = 0;
		stime = Time.time;
		score = 0;

		start1=GameObject.Find("Start");
		start2 = GameObject.Find ("start");
		great = GameObject.Find ("great");
		//sad = GameObject.Find ("sad");


		Debug.Log ("speed " + speed);

		GameObject.Find ("Button").GetComponent<Button> ().onClick.AddListener (checkLittleStar1);
		GameObject.Find ("Button (1)").GetComponent<Button> ().onClick.AddListener (checkLittleStar2);
		GameObject.Find ("Button (2)").GetComponent<Button> ().onClick.AddListener (checkLittleStar3);
		GameObject.Find ("Button (3)").GetComponent<Button> ().onClick.AddListener (checkLittleStar4);
		GameObject.Find ("Button (4)").GetComponent<Button> ().onClick.AddListener (checkLittleStar5);
		GameObject.Find ("Button (5)").GetComponent<Button> ().onClick.AddListener (checkLittleStar6);


		trans1 = GameObject.Find ("star1").GetComponent<Transform> ();
		trans2 = GameObject.Find ("star2").GetComponent<Transform> ();
		trans3 = GameObject.Find ("star3").GetComponent<Transform> ();
		trans4 = GameObject.Find ("star4").GetComponent<Transform> ();
		trans5 = GameObject.Find ("star5").GetComponent<Transform> ();
		trans6 = GameObject.Find ("star6").GetComponent<Transform> ();
		trans7 = GameObject.Find ("star7").GetComponent<Transform> ();
		trans8 = GameObject.Find ("star8").GetComponent<Transform> ();
		trans9 = GameObject.Find ("star9").GetComponent<Transform> ();
		trans10 = GameObject.Find ("star10").GetComponent<Transform> ();
		trans11 = GameObject.Find ("star11").GetComponent<Transform> ();
		trans12 = GameObject.Find ("star12").GetComponent<Transform> ();
		trans13 = GameObject.Find ("star13").GetComponent<Transform> ();
		trans14 = GameObject.Find ("star14").GetComponent<Transform> ();


	}

	// Update is called once per frame
	void Update () {
		ctime = Time.time;
		time = ctime - stime;

		if (time>=0.2) {
			trans1.Translate (0, speed * Time.deltaTime, 0);
			trans2.Translate (0, speed * Time.deltaTime, 0);
			trans3.Translate (0, speed * Time.deltaTime, 0);
			trans4.Translate (0, speed * Time.deltaTime, 0);
			trans5.Translate (0, speed * Time.deltaTime, 0);
			trans6.Translate (0, speed * Time.deltaTime, 0);
			trans7.Translate (0, speed * Time.deltaTime, 0);
			trans8.Translate (0, speed * Time.deltaTime, 0);
			trans9.Translate (0, speed * Time.deltaTime, 0);
			trans10.Translate (0, speed * Time.deltaTime, 0);
			trans11.Translate (0, speed * Time.deltaTime, 0);
			trans12.Translate (0, speed * Time.deltaTime, 0);
			trans13.Translate (0, speed * Time.deltaTime, 0);
			trans14.Translate (0, speed * Time.deltaTime, 0);

		
		}

		if (stay > 0) {
			great.SetActive (true);
			stay = stay - 1;
			//sad.SetActive(false);
		} else {
			great.SetActive (false);
		}



		start1.GetComponent<Button>().onClick.AddListener(clickstart);



		if (trans14.position.y < -2){

			Time.timeScale = 0;
			stime = Time.time;

			Application.LoadLevel ("Score");
		}
	}

	void clickstart(){

		start1.SetActive (false);
		start2.SetActive (false);
		//sad.SetActive(false);
		great.SetActive(false);
		Time.timeScale = 1;
		stime = Time.time;



	}
	void checkLittleStar1(){
		if (trans1.position.y < 0 && trans1.position.y > -1 && s1) {

			stay = 5;
			s1 = false;
			score += 100.0 / 14;
		} 
		if (trans2.position.y<0 && trans2.position.y>-1 && s2) {
			score += 100.0 / 14;
			stay=5;
			s2 = false;
		} 
		if (trans14.position.y<0 && trans14.position.y>-1 && s14) {
			stay=5;
			score += 100.0 / 14;
			s14 = false;
		}


	}

	void checkLittleStar5(){
		if (trans3.position.y<0 && trans3.position.y>-1 && s3) {
			score += 100.0 / 14;
			Debug.Log ("great do 4");
			s3 = false;
			stay=5;
		} 
		if (trans4.position.y<0 && trans4.position.y>-1 && s4) {
			score += 100.0 / 14;
			s4 = false;
			stay=5;
			Debug.Log ("great do 5");
		} 
		if (trans7.position.y<0 && trans7.position.y>-1 && s7) {
			s7 = false;
			score += 100.0 / 14;
			stay=5;
			Debug.Log ("great do 6");
		} 

	}

	void checkLittleStar6(){
		if (trans5.position.y<0 && trans5.position.y>-1 && s5) {
			s5 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 7");
			stay=5;
		} 
		if (trans6.position.y<0 && trans6.position.y>-1 && s6) {
			s6 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 8");
			stay=5;
		} 

	}

	void checkLittleStar4(){
		if (trans8.position.y<0 && trans8.position.y>-1 && s8) {
			s8 = false;
			score += 100.0 / 14;
			stay=5;
			Debug.Log ("great do 9");
		} 
		if (trans9.position.y<0 && trans9.position.y>-1 && s9) {
			s9 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 10");
			stay=5;
		} 

	}

	void checkLittleStar3(){
		if (trans10.position.y<0 && trans10.position.y>-1 && s10) {
			s10 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 11");
			stay=5;
		}

		if (trans11.position.y<0 && trans11.position.y>-1 && s11) {
			s11 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 12");
			stay=5;
		} 

	}

	void checkLittleStar2(){
		if (trans12.position.y<0 && trans12.position.y>-1 && s12) {
			s12 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 13");
			stay=5;
		} 
		if (trans13.position.y<0 && trans13.position.y>-1 && s13) {
			s13 = false;
			score += 100.0 / 14;
			Debug.Log ("great do 14");
			stay=5;
		}

	}



}
