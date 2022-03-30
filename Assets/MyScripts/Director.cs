using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Director : MonoBehaviour
{
    public GameObject score_object = null;//textオブジェクト
    public float time = 2; //UI消去時間を決定

    public Text timerText;
    public float totalTime;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "Level " + (GoalEvent.counter + 1);
        Destroy(score_object,time); //一定時間後消去
    }

    // Update is called once per frame
    void Update()
    {
        //タイマー
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();

        //タイムオーバー
        if(seconds == 0)
        {
            FadeManager.Instance.LoadScene("GameOver", 0.3f);
        }

        //ゴール時
        if(GoalEvent.goalflag == true)
        {
            //Debug.Log(GoalEvent.counter);
            if(GoalEvent.counter == 3)
            {
                GoalEvent.counter = 0;
                FadeManager.Instance.LoadScene("Ending",0.3f);
            }
            GoalEvent.goalflag = false;
        }

        
    }
}
