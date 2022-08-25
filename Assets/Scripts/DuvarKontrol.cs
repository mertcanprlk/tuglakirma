using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarKontrol : MonoBehaviour {
	public GameObject carpma;
	public AudioClip sesEfekti;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D diger){
		AudioSource.PlayClipAtPoint (sesEfekti, transform.position);
		Vector3 pos = diger.contacts [0].point;
		GameObject go = Instantiate (carpma, pos, Quaternion.identity)as GameObject;
		Destroy (go, 1f);
	}
}
