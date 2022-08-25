using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour {
	public UnityEngine.UI.Text puan;
	// Use this for initialization
	void Start () {
		
		puan.text = "Puanınız:"+GameObject.FindObjectOfType<Puan> ().GetComponent<Puan> ().PuaniAl();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AnaSahneyeGec(){
		SceneManager.LoadScene (0);
	}
}
