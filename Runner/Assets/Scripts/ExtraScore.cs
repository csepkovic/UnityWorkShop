using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraScore : MonoBehaviour {
    Rigidbody2D rb2D;
    CameraController cameraController;
    float zRotate = 0f;
    float zRotateIncrease = .01f;
    int upOrDownNumber;
    float stabilizer = 1f;
	// Use this for initialization
	void Start () {
        rb2D = this.GetComponent<Rigidbody2D>();
        cameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
        upOrDownNumber = Random.Range(0, 2);
        if (transform.position.y < -10)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.position = new Vector3(cameraController.end, Random.Range(0f, 4f), 0);
            rb2D.gravityScale = 0f;
            rb2D.velocity = Vector2.zero;
        }
        if (transform.position.y > 4f) {
            rb2D.gravityScale = 1f;
            transform.Rotate(new Vector3(0f, 0, -0.1f));
        } else if (transform.position.y <= 4f) {
            if (upOrDownNumber == 1) {
                zRotate += zRotateIncrease;
            } else if (upOrDownNumber == 0) {
                zRotate -= zRotateIncrease;
            }
            transform.Rotate(new Vector3(0f, 0f, zRotate));
        }
        transform.position += transform.right/2.01f;
	}

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Player") {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.position = new Vector3(cameraController.end, Random.Range(0f, 4f), 0);
            rb2D.gravityScale = 0f;
            rb2D.velocity = Vector2.zero;
            zRotate = 0f;
            zRotateIncrease = 0.1f;
        }
	}
}
