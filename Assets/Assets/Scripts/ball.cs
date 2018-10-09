using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class ball : MonoBehaviour {

    AudioSource audioBall;

    // Use this for initialization
    void Start () {

       

    }
	
	// Update is called once per frame
	void Update () {

      
    }

    void OnCollisionEnter(Collision collision)
    {
        this.audioBall = GetComponent<AudioSource>();

        audioBall = GetComponent<AudioSource>();
        audioBall.Play(0);
        Debug.Log("started");

    }
}
