using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCost : MonoBehaviour
{
    public int cost;
    float costTimer;

    public GameObject eyeHide;
    public GameObject ghost;

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

        sound = GetComponent<AudioSource>();
    }
    void Update()
    {
        costTimer += Time.deltaTime;
        if ((int)costTimer == 10)
        {
            costTimer = 0;
            cost += 1;
        }
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
        rawImage.texture = rt[0];
    }
    public void RoadDefenseRight()
    {
        rawImage.texture = rt[1];
        mapSkillRoadDifenseRight = true;
    }
    public void RoadDefenseLeft()
    {
        rawImage.texture = rt[2];
        mapSkillRoadDifenseLeft = true;
    }

    public void Room1()
    {
        rawImage.texture = rt[3];
    }
    public void Room2()
    {
        rawImage.texture = rt[4];
    }
    public void Room3()
    {
        rawImage.texture = rt[5];
    }
    public void Room4()
    {
        rawImage.texture = rt[6];
    }
    public void Room5()
    {
        rawImage.texture = rt[7];
    }
    public void Room6()
    {
        rawImage.texture = rt[8];
    }
}
