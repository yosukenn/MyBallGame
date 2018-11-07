using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーンを読み込むために必要なシステム

public class BallScript : MonoBehaviour {
    // ボールごとに速度を変える
    private float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(5f, 15f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        // Ballを逃したかどうかを監視する
        if (transform.position.z < -13.0f) {
            //Debug.Log("Game Over");
            //Time.timeScale = 0; // ゲームを止める
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle")) {
            Destroy(gameObject);
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1.0f) {
                collision.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
    }
}
