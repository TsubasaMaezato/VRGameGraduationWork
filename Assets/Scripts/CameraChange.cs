using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour
{
    public GameObject[] cameraObj;

    public GameObject[] hideObj;
    public GameObject[] hideObjPos;

    public GameObject DoorR;
    public GameObject DoorL;
    public Animator[] doorAnim;

    public GameObject uiObj;
    public GameObject title;
    public GameObject tutorial;
    public GameObject curseOBJ;
    public GameObject hidePos;

    public static int objNum;

    int cameraChangeCount;

    int hidePosNum;
    void Start()
    {
        uiObj.SetActive(false);
        title.SetActive(true);
        tutorial.SetActive(false);
        curseOBJ.SetActive(false);
        hidePos.SetActive(false);

        doorAnim[0] = DoorR.GetComponent<Animator>();
        doorAnim[1] = DoorL.GetComponent<Animator>();
        cameraChangeCount = 0;
    }
    void Update()
    {

    }
    public void StartButton()
    {
        title.SetActive(false);
        tutorial.SetActive(true);
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
    /*public void CloseCurseOBJMask()
    {
        objNum = 4;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);
    }*/
    public void CloseRoom1()
    {
        hidePosNum = Random.Range(0, 3);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ1());
    }
    public void CloseRoom2()
    {
        hidePosNum = Random.Range(3, 6);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ2());
    }
    public void CloseRoom3()
    {
        hidePosNum = Random.Range(6, 9);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ3());
    }
    public void CloseRoom4()
    {
        hidePosNum = Random.Range(9, 12);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ4());
    }
    public void CloseRoom5()
    {
        hidePosNum = Random.Range(12, 15);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ5());
    }
    public void CloseRoom6()
    {
        hidePosNum = Random.Range(15, 18);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorClothRight", true);
        doorAnim[1].SetBool("DoorClothLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ6());
    }

    IEnumerator InstOBJ1()
    {
        if(objNum == 0)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

          /*  yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 1)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 14);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

          /*  yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 2)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

            /*yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 3)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

            /*yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        /*if (objNum == 4)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[3].name;

            yield break;
        }*/
    }
    IEnumerator InstOBJ2()
    {
        if (objNum == 0)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

          /*  yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 1)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 2)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

          /*  yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 3)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
      /* if (objNum == 4)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[3].name;

            yield break;
        }*/
    }
    IEnumerator InstOBJ3()
    {
        if (objNum == 0)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 1)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 2)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 3)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
     /*   if (objNum == 4)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[3].name;

            yield break;
        }*/
    }
    IEnumerator InstOBJ4()
    {
        if (objNum == 0)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 1)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

            /*yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 2)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 3)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
      /*  if (objNum == 4)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject N = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[3].name;

            yield break;
        }*/
    }
    IEnumerator InstOBJ5()
    {
        if (objNum == 0)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

            /*yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 1)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject O = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 2)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject B = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

            /*yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 3)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[0].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
       /* if (objNum == 4)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[0].name;

            yield break;
        }*/
    }
    IEnumerator InstOBJ6()
    {
        if (objNum == 0)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 1)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject O = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 2)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(15, 18);
            GameObject B = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[0].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
        if (objNum == 3)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(0, 3);
            GameObject J = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[0].name;

           /* yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[4], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[4].name;*/

            yield break;
        }
      /*  if (objNum == 4)
        {
            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(12, 15);
            GameObject O = Instantiate(hideObj[1], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            O.name = hideObj[1].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(3, 6);
            GameObject B = Instantiate(hideObj[2], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            B.name = hideObj[2].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(6, 9);
            GameObject J = Instantiate(hideObj[3], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            J.name = hideObj[3].name;

            yield return new WaitForSeconds(1);
            hidePosNum = Random.Range(9, 12);
            GameObject N = Instantiate(hideObj[0], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
            N.name = hideObj[0].name;

            yield break;
        }*/
    }
}
