using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalEvent : MonoBehaviour
{
    //OnTriggerEnter関数
    //接触したオブジェクトが引数otherとして渡される
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //接触したオブジェクトのタグが"Player"のとき
            SceneManager.LoadScene("GameScene");
        }
    }
}
