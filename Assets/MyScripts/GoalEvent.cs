using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalEvent : MonoBehaviour
{
    //OnTriggerEnter�֐�
    //�ڐG�����I�u�W�F�N�g������other�Ƃ��ēn�����
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //�ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̂Ƃ�
            SceneManager.LoadScene("GameScene");
        }
    }
}
