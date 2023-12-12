using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caribrator : MonoBehaviour
{
    [SerializeField]
    Transform cameraRig;

    /**
    * HMD�̖ڂ̈ʒu
    */
    [SerializeField]
    Transform hmdEyePos;

    /**
    * ���f���̓��̈ʒu 
    */
    [SerializeField]
    Transform modelHeadPos;

    /**
    * �������p�����[�^
    */
    [SerializeField, Range(-0.5f, 0.5f)]
    float x_offset; //0.01 Unity-Chan��Character1_Head��I�������Ƃ�

    [SerializeField, Range(-0.5f, 0.5f)]
    float y_offset; //0.03

    [SerializeField, Range(-0.5f, 0.5f)]
    float z_offset; //0.11

    private void Start()
    {
        StartCoroutine(Calibrate());
    }
    void Update()
    {
        if (Input.GetKey("c"))
        {
            Calibrate();
        }
    }

    /**
    * �L�����u���[�V���� 
    */
    IEnumerator Calibrate()
    {
        float x = modelHeadPos.transform.position.x - hmdEyePos.transform.position.x + x_offset;
        float y = modelHeadPos.transform.position.y - hmdEyePos.transform.position.y + y_offset;
        float z = modelHeadPos.transform.position.z - hmdEyePos.transform.position.z + z_offset;
        cameraRig.position = new Vector3(cameraRig.position.x + x, cameraRig.position.y + y, cameraRig.position.z + z);

        yield break;
    }
}
