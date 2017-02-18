using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;
	//得点の変数づくり
	public Text scoreText ;
	private int score = 0;
	private Transform playerTrans;


	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		score   = 0;
		SetScore();   //初期スコアを代入して表示
	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
			
		// ボールがあたるものによって点数を変える
		SetScore();

	}
	void OnCollisionEnter (Collision score_tag) {
		if (score_tag.gameObject.tag == "SmallStarTag") {
			score += 0; 
			Debug.Log ("zero");
		} else if (score_tag.gameObject.tag == "LargeStarTag") {
			score += 20;
			Debug.Log ("+20");
		}else if(score_tag.gameObject.tag == "SmallCloudTag" || score_tag.gameObject.tag == "LargeCloudTag") {
			score += 10;
			Debug.Log ("+10");

		}
		SetScore();

	}
	void SetScore()
	{
		scoreText.text = "得点" + score.ToString ();
	}
}