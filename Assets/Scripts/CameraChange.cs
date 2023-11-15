using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour
{
    public GameObject[] hideObj;
    public GameObject[] hideObjPos;

    public GameObject DoorR;
    public GameObject DoorL;
    public Animator[] doorAnim;

    public GameObject tutorial;
    public GameObject curseOBJ;
    public GameObject hidePos;

    int objNum;

    int cameraChangeCount;


    void Start()
    {
        tutorial.SetActive(true);
        curseOBJ.SetActive(false);
        hidePos.SetActive(false);

        doorAnim[0] = DoorR.GetComponent<Animator>();
        doorAnim[1] = DoorL.GetComponent<Animator>();
        cameraChangeCount = 0;
    }
    void Update()
    {

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
        Instantiate(hideObj[objNum], hideObjPos[0].transform.position, Quaternion.identity);
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);
    }
    public void CloseRoom2()
    {
        Instantiate(hideObj[objNum], hideObjPos[1].transform.position, Quaternion.identity);
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);
    }
    public void CloseRoom3()
    {
        Instantiate(hideObj[objNum], hideObjPos[2].transform.position, Quaternion.identity);
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);
    }
    public void CloseRoom4()
    {
        Instantiate(hideObj[objNum], hideObjPos[3].transform.position, Quaternion.identity);
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);
    }
    public void CloseRoom5()
    {
        Instantiate(hideObj[objNum], hideObjPos[4].transform.position, Quaternion.identity);
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);
    }
    public void CloseRoom6()
    {
        Instantiate(hideObj[objNum], hideObjPos[5].transform.position, Quaternion.identity);
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);
    }
}
