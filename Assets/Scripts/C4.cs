using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour {

	public AudioClip key;

	public void onClick(){
		AudioSource.PlayClipAtPoint(key, transform.localPosition);
		Debug.Log ("clickYes");
	}
}
