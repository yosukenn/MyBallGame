using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//システムが必要としている様々なコードを読み込んでいる

// 以下本体
public class PaddleScript : MonoBehaviour {
    //private float speed;
    public float speed; 

	// Use this for initialization
    // 最初に1回だけ実行する初期化のためのコード
	void Start () {
        //speed = 5f;
	}
	
	// Update is called once per frame
    // ゲーム画面が描画されるごとに実行したい処理
	void Update () {
        // 常にキー入力を監視しつつ、パドルを移動させたい
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        //Debug.Log(transform.position.x);
	}
}
