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
        Physics2D.IgnoreLayerCollision(10, 11);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -10){
            cameraController.end+=0.5f;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.position = new Vector3(cameraController.end, Random.Range(0f, 5f) - 1f, 0);
            rb2D.gravityScale = 0f;
            rb2D.velocity = Vector2.zero;
        }
        if (transform.position.x < GameObject.FindWithTag("Light").transform.position.x) {
            rb2D.gravityScale = 2f;
        }
	}

 //   private void OnCollisionEnter2D(Collision2D collision)
	//{
 //       if (collision.gameObject.tag == "Light"){
 //           rb2D.gravityScale = 2f;
 //           Debug.Log("collision with light");
 //       }
	//}
}
