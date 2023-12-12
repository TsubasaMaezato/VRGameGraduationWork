using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultGameController : MonoBehaviour
{
    GameObject fade;
    GameObject player;
    public GameObject posObj;

    public GameObject money;
    public GameObject[] resultObj;
    public GameObject resultObjPos;

    public static int resultNum;
    void Start()
    {

        switch (resultNum)
        {
            case 1:
                GameObject W = Instantiate(resultObj[0], resultObjPos.transform.position, Quaternion.identity);
                W.transform.Rotate(0, 180, 0); money.SetActive(true); break;

            case 2:
                GameObject L = Instantiate(resultObj[1], resultObjPos.transform.position, Quaternion.identity);
                L.transform.Rotate(0, 180, 0); money.SetActive(false); break;
        }

    }
    void Update()
    {
        
    }
}
