using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Director : MonoBehaviour
{
    public GameObject score_object = null;//text�I�u�W�F�N�g
    public float time = 2; //UI�������Ԃ�����

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
