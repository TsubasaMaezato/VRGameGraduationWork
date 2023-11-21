using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Incinerator : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FamillyPicture")
        {
            if (CameraChange.objNum == 0)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene("ResultScene");
            }
        }
        if (other.gameObject.name == "Painting")
        {
            if (CameraChange.objNum == 1)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene("ResultScene");
            }
        }
        if (other.gameObject.name == "Doll")
        {
            if (CameraChange.objNum == 2)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene("ResultScene");
            }
        }
        if (other.gameObject.name == "Pot")
        {
            if (CameraChange.objNum == 3)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene("ResultScene");
            }
        }
        if (other.gameObject.name == "Mask")
        {
            if (CameraChange.objNum == 4)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene("ResultScene");
            }
        }

    }
}
