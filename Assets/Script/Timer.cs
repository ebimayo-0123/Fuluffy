using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
 
public class Timer : MonoBehaviour {
 
	//　トータル制限時間
	private float totalTime;
	//　制限時間（秒）
	[SerializeField]
	private float seconds;
	//　前回Update時の秒数
	private float oldSeconds;
	private TextMeshProUGUI timerText;
    private Rigidbody2D rb2d;
 
	void Start () {
        seconds=10f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<TextMeshProUGUI>();
        rb2d = GameObject.Find("Player").GetComponent<Rigidbody2D>();
	}
 
	void Update () {
        if(rb2d.isKinematic == false)
        {
            //　制限時間が0秒以下なら何もしない
            if (seconds <= 0f) {
                return;
            }
            //　一旦トータルの制限時間を計測；
            seconds -= Time.deltaTime;
    
            //　再設定
    
            //　タイマー表示用UIテキストに時間を表示する
            if((int)seconds != (int)oldSeconds) {
                timerText.text = ((int)seconds).ToString();
            }
            oldSeconds = seconds;
            //　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
            if(seconds <= 0f) {
                Debug.Log("制限時間終了");
            }
	    }
    }
}