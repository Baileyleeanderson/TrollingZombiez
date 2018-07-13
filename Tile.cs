using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public AudioClip hit;
	AudioSource source;
	public GameManager gameManager;

	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		gameManager.AddPoint();
		source.PlayOneShot(hit);
	}
}
