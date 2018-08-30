using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    private int count;
    public Text text;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        updateText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 v = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(v * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup")) {
            other.gameObject.SetActive(false);
            count += 1;
            updateText();
        }
    }

    private void updateText() {
        text.text = "Count " + count;
    }
}
