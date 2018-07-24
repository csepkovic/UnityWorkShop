using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBlock : MonoBehaviour {
    Rigidbody2D rb2D;
    CameraController cameraController;
	// Use this for initialization
	void Start () {
        rb2D = this.GetComponent<Rigidbody2D>();
        cameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -10){
            cameraController.end++;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.position = new Vector3(cameraController.end, 0, 0);
            rb2D.gravityScale = 0f;
            rb2D.velocity = Vector2.zero;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Light"){
            rb2D.gravityScale = 1.5f;
            Debug.Log("collision with light");
        }
	}
}
