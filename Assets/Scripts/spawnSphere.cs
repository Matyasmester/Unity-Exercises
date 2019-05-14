using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnSphere : MonoBehaviour {

    public GameObject sphere;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("space"))
        {
            //Debug.Log("Az input mukszik.");
            Instantiate(sphere, new Vector3(0, 30, 0), Quaternion.identity);
            
        }
    }
}
