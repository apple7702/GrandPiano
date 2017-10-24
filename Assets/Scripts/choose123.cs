using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose123 : MonoBehaviour {

	public void click(){
		if (littleStar.alevel == 1) {
			Application.LoadLevel ("Songs");
		}
		if (littleStar.alevel == 2) {
			Application.LoadLevel ("Songs12");
		}
		if (littleStar.alevel == 3) {
			Application.LoadLevel ("Songs123");
		}
	}
}
