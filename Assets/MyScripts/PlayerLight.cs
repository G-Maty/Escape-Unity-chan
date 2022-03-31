using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    public GameObject target; //追いかけるターゲット
    private Vector3 offset; //ターゲットから照明までの距離

    // Start is called before the first frame update
    void Start()
    {
        //距離の情報を取得
        offset = transform.position - target.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //距離を保ちながら照明を移動
        transform.position = target.transform.position + offset;
    }
}
