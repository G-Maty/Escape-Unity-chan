using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalEvent : MonoBehaviour
{
    public static bool goalflag = false;
    public static int counter = 0;
    //OnTriggerEnter�֐�
    //�ڐG�����I�u�W�F�N�g������other�Ƃ��ēn�����
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goalflag = true;
            counter++;
            //�ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̂Ƃ�
            FadeManager.Instance.LoadScene("GameScene", 0.3f);
        }
    }
}
