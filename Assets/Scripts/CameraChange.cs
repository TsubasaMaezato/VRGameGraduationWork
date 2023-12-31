using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour
{
    public static int pcBGNum;

    public GameObject[] pcBG;

    public GameObject doorAnimObj;

    public AudioSource soundTitleBGM;
    public AudioSource soundMainBGM;

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
        soundTitleBGM.Play();

        uiObj.SetActive(false);
        title.SetActive(true);
        tutorial.SetActive(false);
        curseOBJ.SetActive(false);
        hidePos.SetActive(false);
        pcBG[3].SetActive(false);

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

        pcBGNum = Random.Range(1, 5);

        pcBG[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseTutorial()
    {
        tutorial.SetActive(false);
        curseOBJ.SetActive(true);

        pcBG[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseCurseOBJFamillyPic()
    {
        objNum = 3;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);

        pcBG[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseCurseOBJPainting()
    {
        objNum = 2;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);

        pcBG[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseCurseOBJDoll()
    {
        objNum = 0;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);

        pcBG[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseCurseOBJPot()
    {
        objNum = 1;
        curseOBJ.SetActive(false);
        hidePos.SetActive(true);

        pcBG[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
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
        doorAnim[0].SetBool("DoorCloth", true);
        doorAnim[1].SetBool("DoorRightLeft", true);

        uiObj.SetActive(true);

        StartCoroutine(InstOBJ1());
        soundTitleBGM.Stop();
        soundMainBGM.Play();

        pcBG[3].SetActive(true);
        pcBG[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseRoom2()
    {
        hidePosNum = Random.Range(3, 6);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorCloth", true);
        doorAnim[1].SetBool("DoorRightLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ2());
        soundTitleBGM.Stop();
        soundMainBGM.Play();

        pcBG[3].SetActive(true);
        pcBG[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseRoom3()
    {
        hidePosNum = Random.Range(6, 9);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorCloth", true);
        doorAnim[1].SetBool("DoorRightLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ3());
        soundTitleBGM.Stop();
        soundMainBGM.Play();

        pcBG[3].SetActive(true);
        pcBG[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseRoom4()
    {
        hidePosNum = Random.Range(9, 12);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorCloth", true);
        doorAnim[1].SetBool("DoorRightLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ4());
        soundTitleBGM.Stop();
        soundMainBGM.Play();

        pcBG[3].SetActive(true);
        pcBG[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseRoom5()
    {
        hidePosNum = Random.Range(12, 15);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorCloth", true);
        doorAnim[1].SetBool("DoorRightLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ5());
        soundTitleBGM.Stop();
        soundMainBGM.Play();

        pcBG[3].SetActive(true);
        pcBG[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void CloseRoom6()
    {
        hidePosNum = Random.Range(15, 18);
        GameObject O = Instantiate(hideObj[objNum], hideObjPos[hidePosNum].transform.position, Quaternion.identity);
        O.name = hideObj[objNum].name;
        hidePos.SetActive(false);
        doorAnim[0].SetBool("DoorCloth", true);
        doorAnim[1].SetBool("DoorRightLeft", true);

        uiObj.SetActive(true);
        StartCoroutine(InstOBJ6());
        soundTitleBGM.Stop();
        soundMainBGM.Play();

        pcBG[3].SetActive(true);
        pcBG[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + pcBGNum);
    }
    public void BGMStopIn()
    {
        soundMainBGM.Stop();
        Invoke("BGMStart",5);
    }
    void BGMStart()
    {
        soundMainBGM.Play();
    }
    IEnumerator InstOBJ1()
    {
        yield return new WaitForSeconds(1);
        doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
        if (objNum == 0)
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
        yield return new WaitForSeconds(1);
        doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
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
        yield return new WaitForSeconds(1);
        doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
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
        yield return new WaitForSeconds(1);
        doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
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
        yield return new WaitForSeconds(1);
        doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
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
        yield return new WaitForSeconds(1);
        doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
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
