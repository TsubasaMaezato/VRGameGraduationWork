using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCost : MonoBehaviour
{
    public Animator[] Anim;

    int animCount;
    int cameraAnimNum;
    public int cost;
    float costTimer;

    public GameObject eyeHide;
    public GameObject ghost;
    public GameObject[] eyeCameraObj;

    bool mapSkillRoadDifenseRight;
    bool mapSkillRoadDifenseLeft;

    AudioSource sound;
    public AudioClip[] se;

    public RenderTexture[] rt;
    public RawImage rawImage;
    void Start()
    {
        cost = 3;

        eyeHide.SetActive(false);

        rawImage.texture = rt[0];

        cameraAnimNum = 0;
        Anim[cameraAnimNum].SetBool("OpenBool", true);

        sound = GetComponent<AudioSource>();
        Anim[0] = eyeCameraObj[0].GetComponent<Animator>();
        Anim[1] = eyeCameraObj[1].GetComponent<Animator>();
        Anim[2] = eyeCameraObj[2].GetComponent<Animator>();
        Anim[3] = eyeCameraObj[3].GetComponent<Animator>();
        Anim[4] = eyeCameraObj[4].GetComponent<Animator>();
        Anim[5] = eyeCameraObj[5].GetComponent<Animator>();
        Anim[6] = eyeCameraObj[6].GetComponent<Animator>();
        Anim[7] = eyeCameraObj[7].GetComponent<Animator>();
        Anim[8] = eyeCameraObj[8].GetComponent<Animator>();
    }
    void Update()
    {
        costTimer += Time.deltaTime;
        if ((int)costTimer == 10)
        {
            costTimer = 0;
            cost += 1;
        }

        EyeCamera();
    }
    public void SoundRing()
    {
        if(cost >= 1)
        {
            cost -= 1;
            sound.PlayOneShot(se[0]);
            PlayerVR.hp -= 5;
        }
    }
    public void EyeHide()
    {
        if (cost >= 1)
        {
            cost -= 1;
            PlayerVR.hp -= 5;
            eyeHide.SetActive(true);
        }
    }
    public void RoadDefense()
    {
        if (cost >= 1 && mapSkillRoadDifenseRight)
        {
            cost -= 1;
            GameObject G = Instantiate(ghost, new Vector3(-74, 3.3f, -15), Quaternion.identity);
            G.transform.Rotate(0, 90, 0);

        }
        if (cost >= 1 && mapSkillRoadDifenseLeft)
        {
            cost -= 1;
            GameObject G = Instantiate(ghost, new Vector3(-127.6f, 3.3f, -15), Quaternion.identity);
            G.transform.Rotate(0, 90, 0);
        }

        mapSkillRoadDifenseRight = false;
        mapSkillRoadDifenseLeft = false;
    }

    public void MainHall()
    {
        cameraAnimNum = 0;
        rawImage.texture = rt[0];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void RoadDefenseRight()
    {
        cameraAnimNum = 1;
        rawImage.texture = rt[1];
        mapSkillRoadDifenseRight = true;
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void RoadDefenseLeft()
    {
        cameraAnimNum = 2;
        rawImage.texture = rt[2];
        mapSkillRoadDifenseLeft = true;
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }

    public void Room1()
    {
        cameraAnimNum = 3;
        rawImage.texture = rt[3];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void Room2()
    {
        cameraAnimNum = 4;
        rawImage.texture = rt[4];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void Room3()
    {
        cameraAnimNum = 5;
        rawImage.texture = rt[5];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void Room4()
    {
        cameraAnimNum = 6;
        rawImage.texture = rt[6];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void Room5()
    {
        cameraAnimNum = 7;
        rawImage.texture = rt[7];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    public void Room6()
    {
        cameraAnimNum = 8;
        rawImage.texture = rt[8];
        Anim[cameraAnimNum].SetBool("OpenBool", true);
    }
    void EyeCamera()
    {
        if (cameraAnimNum != 0)
        {
            Anim[0].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 1)
        {
            Anim[1].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 2)
        {
            Anim[2].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 3)
        {
            Anim[3].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 4)
        {
            Anim[4].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 5)
        {
            Anim[5].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 6)
        {
            Anim[6].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 7)
        {
            Anim[7].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 8)
        {
            Anim[8].SetBool("OpenBool", false);
        }
    }
}
