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
    public GameObject uiObj3;
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
    public float cost;
    float costTimer;
    bool costOn;
    int costMinus;
    bool skillCostDown;

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

    public static bool gameStart;

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
      /*  Anim[0] = eyeCameraObj[0].GetComponent<Animator>();
        Anim[1] = eyeCameraObj[1].GetComponent<Animator>();
        Anim[2] = eyeCameraObj[2].GetComponent<Animator>();
        Anim[3] = eyeCameraObj[3].GetComponent<Animator>();
        Anim[4] = eyeCameraObj[4].GetComponent<Animator>();
        Anim[5] = eyeCameraObj[5].GetComponent<Animator>();
        Anim[6] = eyeCameraObj[6].GetComponent<Animator>();
        Anim[7] = eyeCameraObj[7].GetComponent<Animator>();
        Anim[8] = eyeCameraObj[8].GetComponent<Animator>();*/

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
        gameStart = false;
        cost = -1;
        eyeHide.SetActive(false);

        rawImage.texture = rt[0];

        cameraAnimNum = 0;
        Anim[cameraAnimNum].SetBool("OpenBool", true);

        amuletBool = 99;
        amuletOn = false;

        skillCostDown = true;

        amuletPos[0].SetActive(false);
        amuletPos[1].SetActive(false);
        amuletPos[2].SetActive(false);
        amuletPos[3].SetActive(false);
        amuletPos[4].SetActive(false);
        amuletPos[5].SetActive(false);
        amuletPos[6].SetActive(false);
        amuletPos[7].SetActive(false);
        amuletPos[8].SetActive(false);
    }

    void Update()
    {
        if (gameStart)
        {
            AmuletInst();
            CameraCoolDownNow();
            SkillCoolDownNow();
            CostNow();
            EyeCamera();
        }
    }
    public void SoundRing()
    {
        costMinus = 0;

        if (cost >= costMinus && !skillCoolDownBool[0] && CameraChange.objNum == 0 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus1());
            PlayerVR.hp -= 5;
        }
        if (cost >= costMinus && !skillCoolDownBool[0] && CameraChange.objNum == 1 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus1());
            PlayerVR.hp -= 5;
        }
        if (cost >= costMinus && !skillCoolDownBool[0] && CameraChange.objNum == 2 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus1());
            PlayerVR.hp -= 5;
        }
        if (cost >= costMinus && !skillCoolDownBool[0] && CameraChange.objNum == 3 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus1());
            PlayerVR.hp -= 5;
        }
    }
    public void EyeHide()
    {
        costMinus = 1;
        if (cost >= costMinus && !skillCoolDownBool[1] && CameraChange.objNum == 0 && skillCostDown)
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

            skillCostDown = false;
            StartCoroutine(CostMinus2());
            PlayerVR.hp -= 2;
            eyeHide.SetActive(true);
        }
        if (cost >= costMinus && !skillCoolDownBool[1] && CameraChange.objNum == 1 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus2());
            PlayerVR.hp -= 4;
            eyeHide.SetActive(true);
        }
        if (cost >= costMinus && !skillCoolDownBool[1] && CameraChange.objNum == 2 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus2());
            PlayerVR.hp -= 4;
            eyeHide.SetActive(true);
        }
        if (cost >= costMinus && !skillCoolDownBool[1] && CameraChange.objNum == 3 && skillCostDown)
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
            skillCostDown = false;
            StartCoroutine(CostMinus2());
            PlayerVR.hp -= 4;
            eyeHide.SetActive(true);
        }
    }
    public void PowerOutage()
    {
        costMinus = 2;
        if (cost >= costMinus && !skillCoolDownBool[2] && skillCostDown)
        {
            Anim[22].SetBool("UISkill", true);
            skillCoolDownBool[2] = true;
            soundSE.PlayOneShot(se[8]);
            StartCoroutine(CostMinus3());
            skillCostDown = false;
            PlayerVR.hpMinus = 0.05f;
            lmc.SwapLightmapData();
            Invoke("HPMinus", 10);
        }
    }
    public void Poltergeist()
    {
        costMinus = 1;

        if (RoomCollider.roomCol[0])
        {
            if (cost >= costMinus && cameraAnimNum == 3 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                if (RoomCollider.roomCol2[0])
                {
                    PlayerVR.hp -= 2;
                }
                StartCoroutine(CostMinus3());
            }
        }
        if (RoomCollider.roomCol[1])
        {
            if (cost >= costMinus && cameraAnimNum == 4 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                if (RoomCollider.roomCol2[1])
                {
                    PlayerVR.hp -= 2;
                }
                StartCoroutine(CostMinus3());
            }
        }
        if (RoomCollider.roomCol[2])
        {
            if (cost >= costMinus && cameraAnimNum == 5 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                if (RoomCollider.roomCol2[2])
                {
                    PlayerVR.hp -= 2;
                }
                StartCoroutine(CostMinus3());
            }
        }
        if (RoomCollider.roomCol[3])
        {
            if (cost >= costMinus && cameraAnimNum == 6 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                if (RoomCollider.roomCol2[3])
                {
                    PlayerVR.hp -= 2;
                }
                StartCoroutine(CostMinus3());
            }
        }
        if (RoomCollider.roomCol[4])
        {
            if (cost >= costMinus && cameraAnimNum == 7 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                PlayerVR.hp -= 5;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                if (RoomCollider.roomCol2[4])
                {
                    PlayerVR.hp -= 2;
                }
                StartCoroutine(CostMinus3());
            }
        }
        if (RoomCollider.roomCol[5])
        {
            if (cost >= costMinus && cameraAnimNum == 8 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                if (RoomCollider.roomCol2[5])
                {
                    PlayerVR.hp -= 2;
                }
                StartCoroutine(CostMinus3());
            }
        }
      /*  if (RoomCollider.roomCol[7])
        {
            if (cost >= costMinus && cameraAnimNum == 1 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;             
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                StartCoroutine(CostMinus3());
            }
        }
        if (RoomCollider.roomCol[6])
        {
            if (cost >= costMinus && cameraAnimNum == 2 && !skillCoolDownBool[3] && skillCostDown)
            {
                skillCoolDownBool[3] = true;
                Anim[24].SetBool("UISkill", true);

                PoltergeistRandomNum = Random.Range(0, 2);

                switch (PoltergeistRandomNum)
                {
                    case 0: StartCoroutine(ChairAddForce()); break;
                    case 1: mainCanvas.GetComponent<CameraChange>().BGMStopIn(); break;
                }
                skillCostDown = false;
                StartCoroutine(CostMinus3());
            }
        }*/
    }
    public void LockDoor()
    {
        costMinus = 4;
        if (RoomCollider.roomCol[0])
        {

            if (cost >= costMinus && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 0 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 1 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 2 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 3 && !skillCoolDownBool[4] && CameraChange.objNum == 3 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
        if (RoomCollider.roomCol[1])
        {
            if (cost >= costMinus && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 0 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 1 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 2 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 4 && !skillCoolDownBool[4] && CameraChange.objNum == 3 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }

        }
        if (RoomCollider.roomCol[2])
        {
            if (cost >= costMinus && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 0 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 1 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 2 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 5 && !skillCoolDownBool[4] && CameraChange.objNum == 3 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
        if (RoomCollider.roomCol[3])
        {
            if (cost >= costMinus && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 0 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 1 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 2 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 6 && !skillCoolDownBool[4] && CameraChange.objNum == 3 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
        if (RoomCollider.roomCol[4])
        {
            if (cost >= costMinus && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 0 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 1 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 2 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 7 && !skillCoolDownBool[4] && CameraChange.objNum == 3 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
        if (RoomCollider.roomCol[5])
        {
            if (cost >= costMinus && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 0 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 1 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 2 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
            if (cost >= costMinus && cameraAnimNum == 8 && !skillCoolDownBool[4] && CameraChange.objNum == 3 && skillCostDown)
            {
                skillCoolDownBool[4] = true;
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
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
        if (RoomCollider.roomCol[7])
        {
            if (cost >= costMinus && cameraAnimNum == 1 && !skillCoolDownBool[4] && skillCostDown)
            {
                skillCoolDownBool[4] = true;
                Anim[23].SetBool("UISkill", true);
                uiObj2.SetActive(true);
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
        if (RoomCollider.roomCol[6])
        {
            if (cost >= costMinus && cameraAnimNum == 2 && !skillCoolDownBool[4] && skillCostDown)
            {
                skillCoolDownBool[4] = true;
                Anim[23].SetBool("UISkill", true);
                uiObj.SetActive(true);
                skillCostDown = false;
                StartCoroutine(CostMinus4());
            }
        }
    }
    public void RoadDefense()
    {
        costMinus = 4;
        if (cost >= costMinus && cameraAnimNum == 1 && !skillCoolDownBool[5] && skillCostDown)
        {
            skillCoolDownBool[5] = true;
            Anim[25].SetBool("UISkill", true);
            GameObject G = Instantiate(ghost,new Vector3(27,0,-3), Quaternion.identity);
            G.transform.Rotate(0, 180, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus4());
            if (RoomCollider.roomCol2[7])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 2 && !skillCoolDownBool[5] && skillCostDown)
        {
            skillCoolDownBool[5] = true;
            Anim[25].SetBool("UISkill", true);
            GameObject G = Instantiate(ghost, new Vector3(-27, 0, -3), Quaternion.identity);
            G.transform.Rotate(0, 180, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus4());
            if (RoomCollider.roomCol2[6])
            {
                PlayerVR.hp -= 4;
            }
        }
    }
    public void Ghost2()
    {
        costMinus = 3;
        if (cost >= costMinus && cameraAnimNum == 0 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            int i = Random.Range(6, 8);

            switch (i)
            {
                case 6: GameObject G2 = Instantiate(ghost2[0], ghost2Pos[6].transform.position, Quaternion.identity);
                        G2.transform.Rotate(0, 180, 0); break;
                case 7:
                    GameObject G4 = Instantiate(ghost2[0], ghost2Pos[7].transform.position, Quaternion.identity);
                    G4.transform.Rotate(0, 0, 0); break;
            }

            skillCostDown = false;
            if (RoomCollider.roomCol2[0])
            {
                PlayerVR.hp -= 4;
            }
            StartCoroutine(CostMinus5());
        }
        if (cost >= costMinus && cameraAnimNum == 1 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[0], new Vector3(27, 0, 17), Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            skillCostDown = false;
            if (RoomCollider.roomCol2[7])
            {
                PlayerVR.hp -= 4;
            }
            StartCoroutine(CostMinus5());
        }
        if (cost >= costMinus && cameraAnimNum == 2 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[0], new Vector3(-27, 0, 17), Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[6])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 3 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[0].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[0])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 4 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[1].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 90, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[1])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 5 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[2].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, -90, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[2])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 6 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[3].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 180, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[3])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 7 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1], ghost2Pos[4].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, 90, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[4])
            {
                PlayerVR.hp -= 4;
            }
        }
        if (cost >= costMinus && cameraAnimNum == 8 && !skillCoolDownBool[6] && skillCostDown)
        {
            skillCoolDownBool[6] = true;
            Anim[26].SetBool("UISkill", true);
            GameObject G2 = Instantiate(ghost2[1],ghost2Pos[5].transform.position, Quaternion.identity);
            G2.transform.Rotate(0, -90, 0);
            skillCostDown = false;
            StartCoroutine(CostMinus5());
            if (RoomCollider.roomCol2[5])
            {
                PlayerVR.hp -= 4;
            }
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
    public void RoadDefenseRight2()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 9 && amuletBool != 9)
        {
            cameraAnimNum = 9;
            cameraon.CameraSet();
            rawImage.texture = rt[9];
            Anim[27].SetBool("OpenBool", true);
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
    public void RoadDefenseLeft2()
    {
        if (!cameraCoolDownBool && cameraAnimNum != 10 && amuletBool != 10)
        {
            cameraAnimNum = 10;
            cameraon.CameraSet();
            rawImage.texture = rt[10];
            Anim[28].SetBool("OpenBool", true);
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

            if (chair.tag == "ChairRight")
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
                case 0: if (cameraAnimNum == 0) { RoadDefenseRight(); amuletPos[0].SetActive(true); } break;
                case 1: if (cameraAnimNum == 1) { RoadDefenseLeft(); amuletPos[1].SetActive(true); } break;
                case 2: if (cameraAnimNum == 2) { Room1(); amuletPos[2].SetActive(true); } break;
                case 3: if (cameraAnimNum == 3) { Room2(); amuletPos[3].SetActive(true); } break;
                case 4: if (cameraAnimNum == 4) { Room3(); amuletPos[4].SetActive(true); } break;
                case 5: if (cameraAnimNum == 5) { Room4(); amuletPos[5].SetActive(true); } break;
                case 6: if (cameraAnimNum == 6) { Room5(); amuletPos[6].SetActive(true); } break;
                case 7: if (cameraAnimNum == 7) { Room6(); amuletPos[7].SetActive(true); } break;
                case 8: if (cameraAnimNum == 8) { MainHall(); amuletPos[8].SetActive(true); } break;
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

            if (skillCoolDown1 >= 10)
            {
                Anim[21].SetBool("UISkill", false);
                skillCoolDown1 = 0;
                skillCoolDownBool[1] = false;

            }
        }
        if (skillCoolDownBool[2])
        {
            skillCoolDown2 += Time.deltaTime;
            if (skillCoolDown2 >= 10)
            {
                Anim[22].SetBool("UISkill", false);
                skillCoolDown2 = 0;
                skillCoolDownBool[2] = false;

            }
        }
        if (skillCoolDownBool[3])
        {
            skillCoolDown3 += Time.deltaTime;
            if (skillCoolDown3 >= 5)
            {
                Anim[24].SetBool("UISkill", false);
                skillCoolDown3 = 0;
                skillCoolDownBool[3] = false;

            }
        }
        if (skillCoolDownBool[4])
        {
            skillCoolDown4 += Time.deltaTime;

            if (skillCoolDown4 >= 15)
            {
                Anim[23].SetBool("UISkill", false);
                skillCoolDown4 = 0;
                skillCoolDownBool[4] = false;

            }
        }
        if (skillCoolDownBool[5])
        {
            skillCoolDown5 += Time.deltaTime;

            if (skillCoolDown5 >= 15)
            {
                Anim[25].SetBool("UISkill", false);
                skillCoolDown5 = 0;
                skillCoolDownBool[5] = false;

            }
        }
        if (skillCoolDownBool[6])
        {
            skillCoolDown6 += Time.deltaTime;

            if (skillCoolDown6 >= 8)
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
        if (cost <= -1)
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
            case 0: costObj[(int)cost].SetActive(true); if (costOn) { costObj[1].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 1: costObj[(int)cost].SetActive(true); if (costOn) { costObj[2].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 2: costObj[(int)cost].SetActive(true); if (costOn) { costObj[3].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 3: costObj[(int)cost].SetActive(true); if (costOn) { costObj[4].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 4: costObj[(int)cost].SetActive(true); if (costOn) { costObj[5].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 5: costObj[(int)cost].SetActive(true); if (costOn) { costObj[6].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 6: costObj[(int)cost].SetActive(true); if (costOn) { costObj[7].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 7: costObj[(int)cost].SetActive(true); if (costOn) { costObj[8].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 8: costObj[(int)cost].SetActive(true); if (costOn) { costObj[9].GetComponent<FireScript>().CostSet2(); costOn = false; costTimer = 0; } break;
            case 9: costObj[(int)cost].SetActive(true); break;
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
        if (cameraAnimNum != 9)
        {
            Anim[27].SetBool("OpenBool", false);
        }
        if (cameraAnimNum != 10)
        {
            Anim[28].SetBool("OpenBool", false);
        }
    }
    IEnumerator CostMinus1()
    {
        cost -= 1;
        costOn = true;
        skillCostDown = true;
        yield break;
    }
    IEnumerator CostMinus2()
    {
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        skillCostDown = true;
    }
    IEnumerator CostMinus3()
    {
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        skillCostDown = true;
    }
    IEnumerator CostMinus4()
    {
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        skillCostDown = true;
    }
    IEnumerator CostMinus5()
    {
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        yield return new WaitForSeconds(1);
        cost -= 1;
        costOn = true;
        skillCostDown = true;
    }

    void HPMinus()
    {
        PlayerVR.hpMinus = 0.01f;
    }
}
