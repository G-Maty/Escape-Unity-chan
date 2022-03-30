using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Director : MonoBehaviour
{
    public GameObject score_object = null;//text�I�u�W�F�N�g
    public float time = 2; //UI�������Ԃ�����

    public Text timerText;
    public float totalTime;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        //�I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "Level " + (GoalEvent.counter + 1);
        Destroy(score_object,time); //��莞�Ԍ����
    }

    // Update is called once per frame
    void Update()
    {
        //�^�C�}�[
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();

        //�^�C���I�[�o�[
        if(seconds == 0)
        {
            FadeManager.Instance.LoadScene("GameOver", 0.3f);
        }

        //�S�[����
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
