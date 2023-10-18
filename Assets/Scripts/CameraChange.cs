using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour
{
    public GameObject[] hideObj;

    public GameObject gate;

    public GameObject tutorial;
    public GameObject curseOBJ;
    public GameObject hidePos;

    int objNum;

    int cameraChangeCount;
    public RawImage rawImage;

    public RenderTexture[] rt;
    void Start()
    {
        tutorial.SetActive(true);
        curseOBJ.SetActive(false);
        hidePos.SetActive(false);
        cameraChangeCount = 0;
    }
    void Update()
    {
        switch (cameraChangeCount)
        {
            case 0: rawImage.texture = rt[0]; break;
            case 1: rawImage.texture = rt[1]; break;
            case 2: rawImage.texture = rt[2]; break;
            case 3: rawImage.texture = rt[3]; break;
            case 4: rawImage.texture = rt[4]; break;
            case 5: rawImage.texture = rt[5]; break;
            case 6: rawImage.texture = rt[6]; break;
            case 7: rawImage.texture = rt[7]; break;
            case 8: rawImage.texture = rt[8]; break;
        }
    }
    public void CameraChangeRight()
    {
        cameraChangeCount--;
        if(cameraChangeCount < 0)
        {
            cameraChangeCount = 8;
        }
    }
    public void CameraChangeLeft()
    {
        cameraChangeCount++;
        if(cameraChangeCount > 8)
        {
            cameraChangeCount = 0;
        }
    }
    public void CloseTutorial()
    {
        tutorial.SetActive(false);
        curseOBJ.SetActive(true);
    }
    public void CloseCurseOBJFamillyPic()
    {
        objNum = 0;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);
    }
    public void CloseCurseOBJPainting()
    {
        objNum = 1;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);
    }
    public void CloseCurseOBJDoll()
    {
        objNum = 2;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);
    }
    public void CloseCurseOBJPot()
    {
        objNum = 3;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);
    }
    public void CloseCurseOBJMask()
    {
        objNum = 4;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);
    }
    public void CloseRoom1()
    {
        Instantiate(hideObj[objNum], new Vector3(-127.8f, 3, 9.2f), Quaternion.identity);
        hidePos.SetActive(false);
        gate.SetActive(false);
    }
    public void CloseRoom2()
    {
        Instantiate(hideObj[objNum], new Vector3(-139.9f, 3, -5.7f), Quaternion.identity);
        hidePos.SetActive(false);
        gate.SetActive(false);
    }
    public void CloseRoom3()
    {
        Instantiate(hideObj[objNum], new Vector3(-115.9f, 3, 5.7f), Quaternion.identity);
        hidePos.SetActive(false);
        gate.SetActive(false);
    }
    public void CloseRoom4()
    {
        Instantiate(hideObj[objNum], new Vector3(-127.8f, 3, 9.2f), Quaternion.identity);
        hidePos.SetActive(false);
        gate.SetActive(false);
    }
    public void CloseRoom5()
    {
        Instantiate(hideObj[objNum], new Vector3(-84.4f, 3, -5.7f), Quaternion.identity);
        hidePos.SetActive(false);
        gate.SetActive(false);
    }
    public void CloseRoom6()
    {
        Instantiate(hideObj[objNum], new Vector3(-61.76f, 3, -5.7f), Quaternion.identity);
        hidePos.SetActive(false);
        gate.SetActive(false);
    }
}
