using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audiorecord2 : MonoBehaviour {


	private AudioSource goAudioSource; 

	public Button play;
	public Button stop;
	public Button record;
	//public Button twomode;
	public Button onemode;

	int state=1;


	//A boolean that flags whether there's a connected microphone  
	private bool micConnected = false;  

	//The maximum and minimum available recording frequencies  
	private int minFreq;  
	private int maxFreq;  

	//A handle to the attached AudioSource  


	//Use this for initialization  
	void Start() 
	{  
		
		onemode = GameObject.Find ("onemode").GetComponent<Button> ();
		onemode.onClick.AddListener (ononeClick);



		//Check if there is at least one microphone connected  
		if(Microphone.devices.Length <= 0)  
		{  
			//Throw a warning message at the console if there isn't  
			Debug.LogWarning("Microphone not connected!");  
		}  
		else //At least one microphone is present  
		{  
			//Set 'micConnected' to true  
			micConnected = true;  

			//Get the default microphone recording capabilities  
			Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);  

			//According to the documentation, if minFreq and maxFreq are zero, the microphone supports any frequency...  
			if(minFreq == 0 && maxFreq == 0)  
			{  
				//...meaning 44100 Hz can be used as the recording sampling rate  
				maxFreq = 44100;  
			}  

			//Get the attached AudioSource component  
			goAudioSource = this.GetComponent<AudioSource>();  
		}  

		if (micConnected) {  
			//If the audio from any microphone isn't being captured  
			if (!Microphone.IsRecording (null) && state == 1) {
				record = GameObject.Find ("record2").GetComponent<Button> ();
				record.onClick.AddListener (onrecordClick);
				//} else {
				stop = GameObject.Find ("stop2").GetComponent<Button> ();
				stop.onClick.AddListener (onstopClick);
				play=GameObject.Find("Play2").GetComponent<Button>();
				play.onClick.AddListener (onplayClick);
			}
		} 



	}  

	void onplayClick(){
		goAudioSource.Play(); //Playback the recorded audio 
		state=1;
		Debug.Log ("play");
	}

	void onrecordClick(){

		goAudioSource.clip = Microphone.Start(null, true, 20, maxFreq);  
		state = 0;
		Debug.Log ("record");
	}

	void onstopClick(){
		Microphone.End(null); //Stop the audio recording 
		Debug.Log ("stop");
	}

	void ontwoClick(){
		Application.LoadLevel ("TwoPlayerMode");
		Debug.Log ("twomode");
	}

	void ononeClick(){
		Application.LoadLevel ("FreeMode");
		Debug.Log ("onemode");
	}
}
