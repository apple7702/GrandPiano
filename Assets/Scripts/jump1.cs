using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour {

	public void Click(){
		Debug.Log ("111111");
		littleStar.clevel = 1;
		littleStar.speed=-1.0f;
		Application.LoadLevel ("UpgradeMode");

	}
}
