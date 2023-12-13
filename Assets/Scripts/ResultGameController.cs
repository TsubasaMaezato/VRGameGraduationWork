using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultGameController : MonoBehaviour
{
    public GameObject pcBG;

    GameObject fade;
    GameObject player;
    public GameObject posObj;

    public GameObject money;
    public GameObject[] resultObj;
    public GameObject resultObjPos;

    public static int resultNum;

    public GameObject[] ui;

    bool pcReady;
    public static bool vrReady;
    void Start()
    {
        pcReady = false;
        vrReady = false;

        ui[0].SetActive(true);
        ui[1].SetActive(true);
        ui[2].SetActive(true);
        ui[3].SetActive(true);
        ui[4].SetActive(false);
        ui[5].SetActive(false);
        ui[6].SetActive(false);
        ui[7].SetActive(false);
        ui[8].SetActive(false);
        ui[9].SetActive(false);

        pcBG.GetComponent<Image>().sprite = Resources.Load<Sprite>("MonitorBackgroundUI0" + CameraChange.pcBGNum);

        StartCoroutine(LostWindow());
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
        if (pcReady && vrReady)
        {
            SceneManager.LoadScene("MainGame");
        }
    }
    IEnumerator LostWindow()
    {
        yield return new WaitForSeconds(1);
        ui[0].SetActive(false);
        yield return new WaitForSeconds(1);
        ui[1].SetActive(false);
        yield return new WaitForSeconds(1);
        ui[2].SetActive(false);
        yield return new WaitForSeconds(1);
        ui[3].SetActive(false);
        yield return new WaitForSeconds(2);
        ui[4].SetActive(true);
    }
    public void ResultPCOn()
    {
        ui[4].SetActive(false);

        switch (resultNum)
        {
            case 1:
                ui[5].SetActive(true); StartCoroutine(BackToStart()); break;

            case 2:
                ui[6].SetActive(true); StartCoroutine(BackToStart()); break;
        }
    }
    IEnumerator BackToStart()
    {
        yield return new WaitForSeconds(5);
        ui[7].SetActive(true);
    }
    public void Ready()
    {
        ui[7].GetComponent<Animator>().SetBool("StopAnim", true);
        ui[8].SetActive(true);
        ui[9].SetActive(true);
        pcReady = true;
    }
}
