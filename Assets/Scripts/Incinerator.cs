using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Incinerator : MonoBehaviour
{
    public GameObject[] fireObj; 
    public GameObject[] fuels;

    public GameObject fade;

    int objNum;
    public static int fuelsNum;

    public static bool fire;
    bool fuelsOn;
    void Start()
    {
        fuelsNum = 0;
        fuelsOn = true;
        fuels[0].SetActive(false);
        fuels[1].SetActive(false);
        fuels[2].SetActive(false);

        fireObj[0].SetActive(false);
        fireObj[1].SetActive(false);
        fireObj[2].SetActive(false);
        fireObj[3].SetActive(false);
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Fuels")
        {
            if(fuelsNum == 0 && fuelsOn)
            {
                fuels[0].SetActive(true);
                fuelsNum = 1;
                fuelsOn = false;
                Invoke("FuelsIn", 1);
            }
            if (fuelsNum == 1 && fuelsOn)
            {
                fuels[1].SetActive(true);
                fuelsNum = 2;
                fuelsOn = false;
                Invoke("FuelsIn", 1);
            }
            if (fuelsNum == 2 && fuelsOn)
            {
                fuels[2].SetActive(true);
                fuelsNum = 3;
                fuelsOn = false;
            }
        }
        if (fire)
        {
            if (other.gameObject.name == "PictureFtame")
            {
                objNum = 3;
                fireObj[objNum].SetActive(true);
                Invoke("DestroyObj", 10);
            }
            if (other.gameObject.name == "Painting")
            {
                objNum = 1;
                fireObj[objNum].SetActive(true);
                Invoke("DestroyObj", 10);
            }
            if (other.gameObject.name == "CurseDool")
            {
                objNum = 0;
                fireObj[objNum].SetActive(true);
                Invoke("DestroyObj", 10);
            }
            if (other.gameObject.name == "CurseKnife")
            {
                objNum = 2;
                fireObj[objNum].SetActive(true);
                Invoke("DestroyObj", 10);

            }
        }      
    }
    void FuelsIn()
    {
        fuelsOn = true;
    }
    void DestroyObj()
    {
        Destroy(fireObj[objNum]);

        if (CameraChange.objNum == 0)
        {
            StartCoroutine(ResultSceneOn());
        }
        if (CameraChange.objNum == 1)
        {
            StartCoroutine(ResultSceneOn());
        }
        if (CameraChange.objNum == 2)
        {
            StartCoroutine(ResultSceneOn());
        }
        if (CameraChange.objNum == 3)
        {
            StartCoroutine(ResultSceneOn());
        }
    }
    IEnumerator ResultSceneOn()
    {
        fade.GetComponent<Animator>().SetBool("ResultOn",true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ResultScene");
    }
}
