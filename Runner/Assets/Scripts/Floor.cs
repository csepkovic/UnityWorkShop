using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    Rigidbody2D rb2D;
    CameraController cameraController;
    // Use this for initialization
    void Start()
    {
        rb2D = this.GetComponent<Rigidbody2D>();
        cameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
        Physics2D.IgnoreLayerCollision(10, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -13)
        {
            cameraController.end1++;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.position = new Vector3(cameraController.end1, -1.5f, 0f);
            rb2D.gravityScale = 0f;
            rb2D.velocity = Vector2.zero;
        }
        if (transform.position.x < GameObject.FindWithTag("Light").transform.position.x)
        {
            rb2D.gravityScale = 2f;
        }
    }
}
