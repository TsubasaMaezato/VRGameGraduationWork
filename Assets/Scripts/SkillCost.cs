using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
        cost = 3;

        eyeHide.SetActive(false);

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
    public void RoadDefenseRight()
    {
        mapSkillRoadDifenseRight = true;
    }
    public void RoadDefenseLeft()
    {
        mapSkillRoadDifenseLeft = true;

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
}
