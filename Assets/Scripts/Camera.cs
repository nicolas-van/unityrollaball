using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject reference;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - reference.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = reference.transform.position + offset;
	}
}
