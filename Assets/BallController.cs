using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

        //ボールが見える可能性のあるz軸の最小値
        private float visiblePosZ = -6.5f;

        //ゲームオーバを表示するテキスト
        private GameObject gameoverText;

        private GameObject pointText;
        
        private int point = 0;

        // Use this for initialization
        void Start ()
        {
                //シーン中のGameOverTextオブジェクトを取得
                this.gameoverText = GameObject.Find("GameOverText");

                //シーン中のPointTextオブジェクトを取得
                this.pointText = GameObject.Find("PointText");
        }

        // Update is called once per frame
        void Update ()
        {
                //ボールが画面外に出た場合
                if (this.transform.position.z < this.visiblePosZ)
                {
                        //GameoverTextにゲームオーバを表示
                        this.gameoverText.GetComponent<Text> ().text = "Game Over";
                }
        }
        void OnCollisionEnter(Collision other)
        {
                
                if (other.gameObject.tag == "LargeStarTag")
                {
                        // スコアを加算(追加)
                        this.point += 10;
                        //PointTextに獲得した点数を表示(追加)
                        this.pointText.GetComponent<Text> ().text = "Point " + this.point +"pt";
                }

                else if (other.gameObject.tag == "SmallCloudTag")
                {
                        // スコアを加算(追加)
                        this.point += 20;
                        //PointTextに獲得した点数を表示(追加)
                        this.pointText.GetComponent<Text> ().text = "Point " + this.point + "pt";
                }

                else if (other.gameObject.tag == "LargeCloudTag")
                {
                        // スコアを加算(追加)
                        this.point += 50;
                        //PointTextに獲得した点数を表示(追加)
                        this.pointText.GetComponent<Text> ().text = "Point " + this.point + "pt";
                }
        }
         
}