using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalEvent : MonoBehaviour
{
    public static bool goalflag = false;
    public static int counter = 0;
    //OnTriggerEnter関数
    //接触したオブジェクトが引数otherとして渡される
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goalflag = true;
            counter++;
            //接触したオブジェクトのタグが"Player"のとき
            FadeManager.Instance.LoadScene("GameScene", 0.3f);
        }
    }
}
