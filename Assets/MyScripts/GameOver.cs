using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L�[���}�E�X�̓���
        if(Input.anyKey)
        {
            FadeManager.Instance.LoadScene("MainMenu",0.3f);
        }
    }
}
