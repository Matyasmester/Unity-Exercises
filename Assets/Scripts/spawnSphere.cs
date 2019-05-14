using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnSphere : MonoBehaviour {

    public Vector3 pos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("space"))
        {
            //Debug.Log("Az input mukszik.");
            FindObjectOfType<MeshRenderer>().enabled = true;
            FindObjectOfType<Transform>().position = pos;
            
        }
    }
}
