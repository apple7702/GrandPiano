using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump3 : MonoBehaviour {

	public void Click(){
		littleStar.clevel = 3;
		littleStar.speed = -2f;
		Application.LoadLevel ("UpgradeMode3");

	}
}

