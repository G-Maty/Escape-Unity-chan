using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickEvents : MonoBehaviour
{
    public void GameStart()
    {
        FadeManager.Instance.LoadScene("GameScene", 0.3f);
    }
}
