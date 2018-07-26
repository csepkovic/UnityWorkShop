using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject floorCube;
    public GameObject player;
    public Vector3 playerCamera;
    public float end;
    public float end1;
    float rando;
    float smootherFloat = 0;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 450; i++)
        {
            rando = Random.Range(0f, 5f) - 1f;
            GameObject obj = (GameObject)Instantiate(Resources.Load("Floor Block"), new Vector3(i/2, rando, 0), Quaternion.identity);
            end = i/2;
            end1 = i/2;
            if (i % 2 == 0){
                GameObject obj1 = (GameObject)Instantiate(Resources.Load("Floor"), new Vector3(i/2, -1.5f, 0f), Quaternion.identity);
            }
        }
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
	
	// Update is called once per frame
	void Update () {
        playerCamera = new Vector3(player.transform.position.x+5, player.transform.position.y, player.transform.position.z-13);
        transform.position = playerCamera;
	}
}
