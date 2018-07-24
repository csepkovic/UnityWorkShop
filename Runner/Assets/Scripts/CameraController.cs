using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject floorCube;
    public GameObject player;
    public Vector3 playerCamera;
    public float end;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 150; i++)
        {
            GameObject obj = (GameObject)Instantiate(Resources.Load("Floor Block"), new Vector3(i, 0, 0), Quaternion.identity);
            end = i;
        }
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
	
	// Update is called once per frame
	void Update () {
        playerCamera = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z-10);
        transform.position = playerCamera;
	}
}
