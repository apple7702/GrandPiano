using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(littleStar.clevel==1 ){
			littleStar.score=littleStar.score/2;
		}
		if(littleStar.clevel==2){
			littleStar.score=littleStar.score/3;
		}
		if(littleStar.clevel==3){
			littleStar.score=littleStar.score/3;
		}
	}
	
	// Update is called once per frame
	void Update () {



		Text s = GameObject.Find("score").GetComponent<Text>();
		s.text="Your Score is: "+(int)littleStar.score+".";


		if (littleStar.score >= 60) {

			if (littleStar.alevel < littleStar.clevel + 1 && littleStar.clevel<3) {
				littleStar.alevel = littleStar.clevel + 1;
			}
		
		}
	}
}
