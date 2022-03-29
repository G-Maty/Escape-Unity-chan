using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GoalEvent.goalflag == true)
        {
            //Debug.Log(GoalEvent.counter);
            if(GoalEvent.counter == 3)
            {
                FadeManager.Instance.LoadScene("Ending",0.3f);
            }
            GoalEvent.goalflag = false;
        }
    }
}
