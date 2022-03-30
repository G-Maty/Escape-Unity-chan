using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    public GameObject target; //�ǂ�������^�[�Q�b�g
    private Vector3 offset; //�^�[�Q�b�g����Ɩ��܂ł̋���

    // Start is called before the first frame update
    void Start()
    {
        //�����̏����擾
        offset = transform.position - target.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //������ۂ��Ȃ���Ɩ����ړ�
        transform.position = target.transform.position + offset;
    }
}
