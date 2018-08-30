using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour {

    public float speed;

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(45, 45, 45) * speed * Time.deltaTime);
	}
}
