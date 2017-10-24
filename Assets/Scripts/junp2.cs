using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junp2 : MonoBehaviour {

	public void Click(){
		littleStar.clevel = 2;
		littleStar.speed = -1.2f;
		Application.LoadLevel ("UpgradeMode2");

	}
}
