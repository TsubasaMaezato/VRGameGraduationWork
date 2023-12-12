using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class SkillCost : MonoBehaviour
{ 
    public GameObject mainCanvas;
    int PoltergeistRandomNum;

    public AudioSource soundSE;
    public AudioClip[] se;

    int seNum;

    GameObject chair;
    int chairNum;
    Rigidbody chairRb;

    public GameObject uiObj;
    public GameObject uiObj2;
    public GameObject[] roomCollider;

    public Slider skillCoolDownSlider;

    public CameraOn cameraon;
    public GameObject[] skillButton;
    public GameObject[] costObj;

    public GameObject[] ghost2;
    public GameObject[] ghost2Pos;

    public LightMapChange lmc;
    public Animator[] Anim;

    float cameraCoolDown;
    int costCount;
    public static int cameraAnimNum;
    public int cost;
    float costTimer;
    bool costOn;

    public GameObject coolDownOBJ;
    public GameObject eyeHide;
    public GameObject ghost;
    public GameObject[] eyeCameraObj;
    public GameObject[] lockDoorObj;

    public static bool amuletOn;
    public static int amuletBool;
    public GameObject[] amuletPos;
    public GameObject amulet;

    bool[] skillCoolDownBool = new bool[7];
    bool cameraCoolDownBool;

    bool mapSkillRoadDifenseRight;
    bool mapSkillRoadDifenseLeft;

    public RenderTexture[] rt;
    public RawImage rawImage;

    float skillCoolDown;
    float skillCoolDown1;
    float skillCoolDown2;
    float skillCoolDown3;
    float skillCoolDown4;
    float skillCoolDown5;
    float skillCoolDown6;
    private void Awake()
    {
        Anim[0] = eyeCameraObj[0].GetComponent<Animator>();
        Anim[1] = eyeCameraObj[1].GetComponent<Animator>();
        Anim[2] = eyeCameraObj[2].GetComponent<Animator>();
        Anim[3] = eyeCameraObj[3].GetComponent<Animator>();
        Anim[4] = eyeCameraObj[4].GetComponent<Animator>();
        Anim[5] = eyeCameraObj[5].GetComponent<Animator>();
        Anim[6] = eyeCameraObj[6].GetComponent<Animator>();
        Anim[7] = eyeCameraObj[7].GetComponent<Animator>();
        Anim[8] = eyeCameraObj[8].GetComponent<Animator>();

        costObj[0].SetActive(false);
        costObj[1].SetActive(false);
        costObj[2].SetActive(false);
        costObj[3].SetActive(false);
        costObj[4].SetActive(false);
        costObj[5].SetActive(false);
        costObj[6].SetActive(false);
        costObj[7].SetActive(false);
        costObj[8].SetActive(false);
        costObj[9].SetActive(false);

        Anim[19] = coolDownOBJ.GetComponent<Animator>();

        Anim[20] = skillButton[0].GetComponent<Animator>();
        Anim[21] = skillButton[1].GetComponent<Animator>();
        Anim[22] = skillButton[2].GetComponent<Animator>();
        Anim[23] = skillButton[3].GetComponent<Animator>();
        Anim[24] = skillButton[4].GetComponent<Animator>();
        Anim[25] = skillButton[5].GetComponent<Animator>();
        Anim[26] = skillButton[6].GetComponent<Animator>();
    }
    void Start()
    {
        cost = -1;
        eyeHide.SetActive(false);

        rawImage.texture = rt[0];

        cameraAnimNum = 0;
        Anim[cameraAnimNum].SetBool("OpenBool", true);

        amuletBool = 99;
        amuletOn = false;
    }

    void Update()
    {
        AmuletInst();
        CameraCoolDownNow();
        SkillCoolDownNow();
        CostNow();
        EyeCamera();
    }
    public void SoundRing()
    {
        if (cost >= 1 && !skillCoolDownBool[0] && CameraChange.objNum == 0)
        {
            Anim[20].SetBool("UISkill", true);
            skillCoolDownBool[0] = true;

            seNum = Random.Range(0, 2);
            if(seNum == 0)
            {
                soundSE.PlayOneShot(se[0],0.3f);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[1]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
        }
        if (cost >= 0 && !skillCoolDownBool[0] && CameraChange.objNum == 1)
        {
            Anim[20].SetBool("UISkill", true);
            skillCoolDownBool[0] = true;

            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[3], 0.3f);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[2]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
        }
        if (cost >= 0 && !skillCoolDownBool[0] && CameraChange.objNum == 2)
        {
            Anim[20].SetBool("UISkill", true);
            skillCoolDownBool[0] = true;

            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[3], 0.3f);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[2]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
        }
        if (cost >= 0 && !skillCoolDownBool[0] && CameraChange.objNum == 3)
        {
            Anim[20].SetBool("UISkill", true);
            skillCoolDownBool[0] = true;

            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[0], 0.3f);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[1]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
        }
    }
    public void EyeHide()
    {
        if (cost >= 0 && !skillCoolDownBool[1] && CameraChange.objNum == 0)
        {
            Anim[21].SetBool("UISkill", true);
            skillCoolDownBool[1] = true;
            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[4]);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[6]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
            eyeHide.SetActive(true);
        }
        if (cost >= 0 && !skillCoolDownBool[1] && CameraChange.objNum == 1)
        {
            Anim[21].SetBool("UISkill", true);
            skillCoolDownBool[1] = true;

            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[5]);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[6]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
            eyeHide.SetActive(true);
        }
        if (cost >= 0 && !skillCoolDownBool[1] && CameraChange.objNum == 2)
        {
            Anim[21].SetBool("UISkill", true);
            skillCoolDownBool[1] = true;

            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[5]);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[7]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
            eyeHide.SetActive(true);
        }
        if (cost >= 0 && !skillCoolDownBool[1] && CameraChange.objNum == 3)
        {
            Anim[21].SetBool("UISkill", true);
            skillCoolDownBool[1] = true;

            seNum = Random.Range(0, 2);
            if (seNum == 0)
            {
                soundSE.PlayOneShot(se[4]);
            }
            if (seNum == 1)
            {
                soundSE.PlayOneShot(se[7]);
            }

            costOn = true;
            cost -= 1;
            PlayerVR.hp -= 5;
            eyeHide.SetActive(true);
        }
    }
    public void PowerOutage()
    {
        if (cost >= 0 && !skillCoolDownBool[2])
        {
            Anim[22].SetBool("UISkill", true);
            skillCoolDownBool[2] = true;
            soundSE.PlayOneShot(se[8]);
            cost -= 1;
            PlayerVR.hp -= 5;
            lmc.SwapLightmapData();
            costOn = true;
        }
    }
    public void Poltergeist()
    {
        if (RoomCollider.roomCol[0])
        {
            if (cost >= 0 && cameraAnimNum == 3 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[1])
        {
            if (cost >= 0 && cameraAnimNum == 4 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[2])
        {
            if (cost >= 0 && cameraAnimNum == 5 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[3])
        {
            if (cost >= 0 && cameraAnimNum == 6 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[4])
        {
            if (cost >= 0 && cameraAnimNum == 7 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[5])
        {
            if (cost >= 0 && cameraAnimNum == 8 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[7])
        {
            if (cost >= 0 && cameraAnimNum == 1 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[6])
        {
            if (cost >= 0 && cameraAnimNum == 2 && !skillCoolDownBool[3])
            {
                skillCoolDownBool[3] = true;
                cost -= 1;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                costOn = true;
            }
        }
    }
    public void LockDoor()
    {
        if (RoomCollider.roomCol[0])
        {
            if (cost >= 0 && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 0)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[0].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 1)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[0].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 2)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[0].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 3)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[0].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[1])
        {
            if (cost >= 0 && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 0)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[1].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 1)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[1].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 2)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[1].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 3)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[1].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }

        }
        if (RoomCollider.roomCol[2])
        {
            if (cost >= 0 && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 0)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[2].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 1)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[2].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 2)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[2].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 3)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[2].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[3])
        {
            if (cost >= 0 && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 0)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[3].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 1)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[3].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 2)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[3].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 3)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[3].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 0, 0);
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[4])
        {
            if (cost >= 0 && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 0)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[4].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 1)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[4].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 2)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[4].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 3)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[4].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, -90, 0);
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[5])
        {
            if (cost >= 0 && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 0)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[5].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 1)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[5].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 2)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[9]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[5].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
            if (cost >= 0 && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 3)
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                seNum = Random.Range(0, 2);
                if (seNum == 0)
                {
                    soundSE.PlayOneShot(se[11]);
                }
                if (seNum == 1)
                {
                    soundSE.PlayOneShot(se[10]);
                }
                GameObject G3 = Instantiate(ghost, lockDoorObj[5].transform.position, Quaternion.identity);
                G3.transform.Rotate(0, 90, 0);
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[7])
        {
            if (cost >= 0 && cameraAnimNum == 1 && !skillCoolDownBool[4])
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                uiObj2.SetActive(true);
                costOn = true;
            }
        }
        if (RoomCollider.roomCol[6])
        {
            if (cost >= 0 && cameraAnimNum == 2 && !skillCoolDownBool[4])
            {
                skillCoolDownBool[4] = true;
                cost -= 1;
                Anim[23].SetBool("UISkill", true);
                uiObj.SetActive(true);
                costOn = true;
            }
        }
    }
    public void RoadDefense()
    {

        if (cost >= 0 && cameraAnimNum == 1 && !skillCoolDownBool[5])
        {
            skillCoolDownBool[5] = true;
            cost -= 1;
            Anim[25].SetBool("UISkill", true);
            GameObject G = Instantiate(ghost,new Vector3(27,0,-3), Quaternion.identity);
            G.transform.Rotate(0, 180, 0);
            costOn = true;

        }
        if (cost >= 0 && cameraAnimNum == 2 && !skillCoolDownBool[5])
        {
            skillCoolDownBool[5] = true;
            cost -= 1;
            Anim[25].SetBool("UISkill", true);
            GameObject G = Instantiate(ghost, new Vector3(-27, 0, -3), Quaternion.identity);
            G.transform.Rotate(0, 180, 0);
            costOn = true;
        }
    }
    public void Ghost2()
    {

        if (cost >= 0 && cameraAnimNum == 1 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[0], new Vector3(27, 0, 17), Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 2 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[0], new Vector3(-27, 0, 17), Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 3 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[0].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 4 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[1].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 90, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 5 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[2].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, -90, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 6 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[3].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 7 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[4].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 90, 0);
            costOn = true;
        }
        if (cost >= 1 && cameraAnimNum == 8 && !skillCoolDownBool[6])
        {
            skillCoolDownBool[6] = true;
            cost -= 1;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1],ghost2Pos[5].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, -90, 0);
            costOn = true;
        }
    }

    public void MainHall()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 0 && amuletBool != 0)
        {
            cameraAnimNum = 0;
            cameraon.CameraSet();
            rawImage.texture = rt[0];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void RoadDefenseRight()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 1 && amuletBool != 1)
        {
            cameraAnimNum = 1;
            cameraon.CameraSet();
            rawImage.texture = rt[1];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void RoadDefenseLeft()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 2 && amuletBool != 2)
        {
            cameraAnimNum = 2;
            cameraon.CameraSet();
            rawImage.texture = rt[2];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }

    public void Room1()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 3 && amuletBool != 3)
        {
            cameraAnimNum = 3;
            cameraon.CameraSet();
            rawImage.texture = rt[3];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void Room2()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 4 && amuletBool != 4)
        {
            cameraAnimNum = 4;
            cameraon.CameraSet();
            rawImage.texture = rt[4];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void Room3()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 5 && amuletBool != 5)
        {
            cameraAnimNum = 5;
            cameraon.CameraSet();
            rawImage.texture = rt[5];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void Room4()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 6 && amuletBool != 6)
        {
            cameraAnimNum = 6;
            cameraon.CameraSet();
            rawImage.texture = rt[6];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void Room5()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 7 && amuletBool != 7)
        {
            cameraAnimNum = 7;
            cameraon.CameraSet();
            rawImage.texture = rt[7];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }
    public void Room6()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 8 && amuletBool != 8)
        {
            cameraAnimNum = 8;
            cameraon.CameraSet();
            rawImage.texture = rt[8];
            Anim[cameraAnimNum].SetBool("OpenBool", true);
            Anim[19].SetBool("CoolDownBool", true);
            cameraCoolDownBool = true;
        }
    }

    IEnumerator ChairAddForce()
    {
        if (RoomCollider.roomCol[0])
        {
            chairNum = Random.Range(1, 17);

            chair = GameObject.Find("Chair" + chairNum);
            chairRb = chair.GetComponent<Rigidbody>();

            if(chair.tag == "ChairRight")
            {
                chairRb.AddForce(transform.right * 10, ForceMode.Impulse);
            }
            if (chair.tag == "ChairLeft")
            {
                chairRb.AddForce(transform.right * -10, ForceMode.Impulse);
            }

            yield return new WaitForSeconds(5); 
            chair.GetComponent<Chair>().PositionReset();
            yield break;
        }
        if (RoomCollider.roomCol[1])
        {
            chairNum = Random.Range(17, 19);

            chair = GameObject.Find("Chair" + chairNum);
            chairRb = chair.GetComponent<Rigidbody>();

            chairRb.AddForce(transform.forward * -10, ForceMode.Impulse);
            yield return new WaitForSeconds(5);
            chair.GetComponent<Chair>().PositionReset();
            yield break;
        }
        if (RoomCollider.roomCol[3])
        {
            chairNum = Random.Range(19, 27);

            chair = GameObject.Find("Chair" + chairNum);
            chairRb = chair.GetComponent<Rigidbody>();

            if (chair.tag == "ChairRight")
            {
                chairRb.AddForce(transform.forward * -10, ForceMode.Impulse);
            }
            if (chair.tag == "ChairLeft")
            {
                chairRb.AddForce(transform.forward * 10, ForceMode.Impulse);
            }
            yield return new WaitForSeconds(5);
            chair.GetComponent<Chair>().PositionReset();
            yield break;
        }
        if (RoomCollider.roomCol[4])
        {
            chair = GameObject.Find("Chair27");
            chairRb = chair.GetComponent<Rigidbody>();

            chairRb.AddForce(transform.forward * -10, ForceMode.Impulse);
            yield return new WaitForSeconds(5);
            chair.GetComponent<Chair>().PositionReset();
            yield break;
        }
        if (RoomCollider.roomCol[5])
        {
            chair = GameObject.Find("Chair28");
            chairRb = chair.GetComponent<Rigidbody>();
            chairRb.AddForce(transform.right * -10, ForceMode.Impulse);
            yield return new WaitForSeconds(5);
            chair.GetComponent<Chair>().PositionReset();
            yield break;
        }

    }
    void AmuletInst()
    {
        if (amuletOn)
        {
            switch (amuletBool)
            {
                case 0: if (cameraAnimNum == 0) { cameraAnimNum = 1; rawImage.texture = rt[1]; Instantiate(amulet, amuletPos[0].transform.position, Quaternion.identity); } break;
                case 1: if (cameraAnimNum == 1) { cameraAnimNum = 2; rawImage.texture = rt[2]; Instantiate(amulet, amuletPos[1].transform.position, Quaternion.identity); } break;
                case 2: if (cameraAnimNum == 2) { cameraAnimNum = 3; rawImage.texture = rt[3]; Instantiate(amulet, amuletPos[2].transform.position, Quaternion.identity); } break;
                case 3: if (cameraAnimNum == 3) { cameraAnimNum = 4; rawImage.texture = rt[4]; Instantiate(amulet, amuletPos[3].transform.position, Quaternion.identity); } break;
                case 4: if (cameraAnimNum == 4) { cameraAnimNum = 5; rawImage.texture = rt[5]; Instantiate(amulet, amuletPos[4].transform.position, Quaternion.identity); } break;
                case 5: if (cameraAnimNum == 5) { cameraAnimNum = 6; rawImage.texture = rt[6]; Instantiate(amulet, amuletPos[5].transform.position, Quaternion.identity); } break;
                case 6: if (cameraAnimNum == 6) { cameraAnimNum = 7; rawImage.texture = rt[7]; Instantiate(amulet, amuletPos[6].transform.position, Quaternion.identity); } break;
                case 7: if (cameraAnimNum == 7) { cameraAnimNum = 8; rawImage.texture = rt[8]; Instantiate(amulet, amuletPos[7].transform.position, Quaternion.identity); } break;
                case 8: if (cameraAnimNum == 8) { cameraAnimNum = 0; rawImage.texture = rt[0]; Instantiate(amulet, amuletPos[8].transform.position, Quaternion.identity); } break;
            }
        }
    }
    void SkillCoolDownNow()
    {
        if (skillCoolDownBool[0])
        {
            skillCoolDown += Time.deltaTime;
            if (skillCoolDown >= 3)
            {
                Anim[20].SetBool("UISkill", false);
                skillCoolDown = 0;
                skillCoolDownBool[0] = false;

            }
        }
        if (skillCoolDownBool[1])
        {
            skillCoolDown1 += Time.deltaTime;

            if (skillCoolDown1 >= 3)
            {
                Anim[21].SetBool("UISkill", false);
                skillCoolDown1 = 0;
                skillCoolDownBool[1] = false;

            }
        }
        if (skillCoolDownBool[2])
        {
            skillCoolDown2 += Time.deltaTime;
            if (skillCoolDown2 >= 13)
            {
                Anim[22].SetBool("UISkill", false);
                skillCoolDown2 = 0;
                skillCoolDownBool[2] = false;

            }
        }
        if (skillCoolDownBool[3])
        {
            skillCoolDown3 += Time.deltaTime;
            if (skillCoolDown3 >= 7)
            {
                Anim[24].SetBool("UISkill", false);
                skillCoolDown3 = 0;
                skillCoolDownBool[3] = false;

            }
        }
        if (skillCoolDownBool[4])
        {
            skillCoolDown4 += Time.deltaTime;

            if (skillCoolDown4 >= 3)
            {
                Anim[23].SetBool("UISkill", false);
                skillCoolDown4 = 0;
                skillCoolDownBool[4] = false;

            }
        }
        if (skillCoolDownBool[5])
        {
            skillCoolDown5 += Time.deltaTime;

            if (skillCoolDown5 >= 3)
            {
                Anim[25].SetBool("UISkill", false);
                skillCoolDown5 = 0;
                skillCoolDownBool[5] = false;

            }
        }
        if (skillCoolDownBool[6])
        {
            skillCoolDown6 += Time.deltaTime;

            if (skillCoolDown6 >= 3)
            {
                Anim[26].SetBool("UISkill", false);
                skillCoolDown6 = 0;
                skillCoolDownBool[6] = false;

            }
        }

    }
    void CostNow()
    {
        if ((int)costTimer == 5)
        {
            costTimer = 0;
            cost += 1;
        }
        if (cost == -1)
        {
            cost = -1;
        }
        if (cost >= 9)
        {
            cost = 9;
        }
        switch (cost)
        {
            case -1: if (costOn) { costObj[0].GetComponent<FireScript>().CostSet2(); costOn = false;} break;
            case 0: costObj[cost].SetActive(true); if (costOn) { costObj[1].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 1: costObj[cost].SetActive(true); if (costOn) { costObj[2].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 2: costObj[cost].SetActive(true); if (costOn) { costObj[3].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 3: costObj[cost].SetActive(true); if (costOn) { costObj[4].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 4: costObj[cost].SetActive(true); if (costOn) { costObj[5].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 5: costObj[cost].SetActive(true); if (costOn) { costObj[6].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 6: costObj[cost].SetActive(true); if (costOn) { costObj[7].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 7: costObj[cost].SetActive(true); if (costOn) { costObj[8].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 8: costObj[cost].SetActive(true); if (costOn) { costObj[9].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 9: costObj[cost].SetActive(true); break;
        }
    }
    void CameraCoolDownNow()
    {
        costTimer += Time.deltaTime;
        if (cameraCoolDownBool)
        {
            cameraCoolDown += Time.deltaTime;

            if (cameraCoolDown >= 3)
            {
                cameraCoolDown = 0;
                cameraCoolDownBool = false;
                Anim[19].SetBool("CoolDownBool", false);
            }
        }
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
