using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject floorCube;
    public GameObject player;
    public Vector3 playerCamera;
    public float end;
    public GameObject[] floorBlocks = new GameObject[225];
    float rando;
    float smootherFloat = 0;
    // Use this for initialization
    void Start()
    {
        rando = Random.Range(0f, 5f) - 1f;
        for (int i = 0; i < 225; i++)
        {
            if (i > 0) {
                rando = floorBlocks[i - 1].transform.position.y;
                rando += (Random.Range(0f, 1f)-0.5f);
            }
            GameObject obj = (GameObject)Instantiate(Resources.Load("Floor Block"), new Vector3(i, rando, 0), Quaternion.identity);
            end = i;
            floorBlocks[i] = obj;
        }
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
	
	// Update is called once per frame
	void Update () {
        playerCamera = new Vector3(player.transform.position.x+5, player.transform.position.y, player.transform.position.z-13);
        transform.position = playerCamera;
	}
}
