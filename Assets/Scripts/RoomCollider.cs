using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCollider : MonoBehaviour
{
    public static bool[] roomCol = new bool[9];
    public static bool Poltergeist;

    public static bool[] roomCol2 = new bool[9];
    // Start is called before the first frame update
    void Start()
    {
        roomCol[0] = true;
        roomCol[1] = true;
        roomCol[2] = true;
        roomCol[3] = true;
        roomCol[4] = true;
        roomCol[5] = true;
        roomCol[6] = true;
        roomCol[7] = true;
        roomCol[8] = true;
    }

    // Update is called once per frame
    void Update()
    {
        Poltergeist = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(gameObject.name == "Main")
            {
                roomCol2[8] = true;
            }
            if(gameObject.name == "RoomCollider1")
            {
                roomCol2[0] = true;
            }
            if (gameObject.name == "RoomCollider2")
            {
                roomCol2[1] = true;
            }
            if (gameObject.name == "RoomCollider3")
            {
                roomCol2[2] = true;
            }
            if (gameObject.name == "RoomCollider4")
            {
                roomCol2[3] = true;
            }
            if (gameObject.name == "RoomCollider5")
            {
                roomCol2[4] = true;
            }
            if (gameObject.name == "RoomCollider6")
            {
                roomCol2[5] = true;
            }
            if(gameObject.name == "LeftCorriderCollider")
            {
                roomCol2[6] = true;
            }
            if (gameObject.name == "RightCorriderCollider")
            {
                roomCol2[7] = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.name == "Main")
            {
                roomCol2[8] = false;
            }
            if (gameObject.name == "RoomCollider1")
            {
                roomCol2[0] = false;
            }
            if (gameObject.name == "RoomCollider2")
            {
                roomCol2[1] = false;
            }
            if (gameObject.name == "RoomCollider3")
            {
                roomCol2[2] = false;
            }
            if (gameObject.name == "RoomCollider4")
            {
                roomCol2[3] = false;
            }
            if (gameObject.name == "RoomCollider5")
            {
                roomCol2[4] = false;
            }
            if (gameObject.name == "RoomCollider6")
            {
                roomCol2[5] = false;
            }
            if (gameObject.name == "LeftCorriderCollider")
            {
                roomCol2[6] = false;
            }
            if (gameObject.name == "RightCorriderCollider")
            {
                roomCol2[7] = false;
            }
        }
    }
}
