using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public GameObject uiObj;
    public GameObject uiObj2;
    public GameObject ghost;
    public GameObject[] ghostPos;
    // Start is called before the first frame update
    void Start()
    {
        uiObj.SetActive(false);
        uiObj2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackUI()
    {
        uiObj.SetActive(false);
        uiObj2.SetActive(false);
    }
    public void Room1()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[0].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, 180, 0);
        uiObj.SetActive(false);
    }
    public void Room2()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[1].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, 90, 0);
        uiObj.SetActive(false);
    }
    public void Room3()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[2].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, -90, 0);
        uiObj.SetActive(false);
    }
    public void Room4()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[3].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, 180, 0);
        uiObj2.SetActive(false);
    }
    public void Room5()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[4].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, 90, 0);
        uiObj2.SetActive(false);
    }
    public void Room6()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[5].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, -90, 0);
        uiObj2.SetActive(false);
    }
    public void LeftCorrider()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[6].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, -90, 0);
        uiObj.SetActive(false);
    }
    public void RightCorrider()
    {
        GameObject G3 = Instantiate(ghost, ghostPos[7].transform.position, Quaternion.identity);
        G3.transform.Rotate(0, 90, 0);
        uiObj2.SetActive(false);
    }
}
