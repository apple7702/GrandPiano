using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cholev : MonoBehaviour {

	public Button level1;
	public Button level2;
	public Button level3;
	//public Button twomode;

	void Start()
	{  
		level1 = GameObject.Find ("Level1").GetComponent<Button> ();
		level1.onClick.AddListener (onlev1Click);
		level2 = GameObject.Find ("Level2").GetComponent<Button> ();
		level2.onClick.AddListener (onlev1Click);
		level3 = GameObject.Find ("Level3").GetComponent<Button> ();
		level3.onClick.AddListener (onlev1Click);
	}

	void onlev1Click(){
		Debug.Log ("aaaa");
		Application.LoadLevel ("UpgradeMode");
	}


}
