﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour {
    // このスクリプトとボールのプレハブを結びつける
    public GameObject ball; // Inspectorからアクセスできる変数を作る

	// Use this for initialization
	void Start () {
        //Instantiate(ball, transform.position, transform.rotation);
        InvokeRepeating("SpawnBall", 0f, 1f);
	}

    void SpawnBall() {
        Instantiate(ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    }

	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle")) {
            Destroy(gameObject);
        }
    }
}