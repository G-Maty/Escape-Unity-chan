using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    Vector3 Staffrollposition;
    public RectTransform rectTransform;
    public float Endpos = 104;

    // Start is called before the first frame update
    void Start()
    {
        Staffrollposition = rectTransform.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (rectTransform.anchoredPosition.y < Endpos)
        {

            Staffrollposition.y += 1f;
            rectTransform.anchoredPosition = Staffrollposition;
        }
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
