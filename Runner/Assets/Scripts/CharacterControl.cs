using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour {
    Rigidbody2D rigidBody;

    bool jumping = false;
	// Use this for initialization
	void Start () {
        rigidBody = this.GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(8, 9);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping){
            rigidBody.AddForce(new Vector2(0, 500));
            jumping = true;
        } 
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidBody.AddForce(new Vector2(100, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidBody.AddForce(new Vector2(-100, 0));
        }
        transform.position += transform.right;
        if (transform.position.y < -15) {
            SceneManager.LoadScene("Main Game");
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Floor") {
            jumping = false;
        } 
	}
}
