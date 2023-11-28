using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOn : MonoBehaviour
{
    public GameObject[] cameraObj;
    void Start()
    {
        cameraObj[0].SetActive(true);
        cameraObj[1].SetActive(false);
        cameraObj[2].SetActive(false);
        cameraObj[3].SetActive(false);
        cameraObj[4].SetActive(false);
        cameraObj[5].SetActive(false);
        cameraObj[6].SetActive(false);
        cameraObj[7].SetActive(false);
        cameraObj[8].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CameraSet()
    {
        if(SkillCost.cameraAnimNum == 0)
        {
            cameraObj[0].SetActive(true);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 1)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(true);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 2)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(true);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 3)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(true);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 4)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(true);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 5)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(true);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 6)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(true);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 7)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(true);
            cameraObj[8].SetActive(false);
        }
        if (SkillCost.cameraAnimNum == 8)
        {
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(false);
            cameraObj[2].SetActive(false);
            cameraObj[3].SetActive(false);
            cameraObj[4].SetActive(false);
            cameraObj[5].SetActive(false);
            cameraObj[6].SetActive(false);
            cameraObj[7].SetActive(false);
            cameraObj[8].SetActive(true);
        }
    }
}
