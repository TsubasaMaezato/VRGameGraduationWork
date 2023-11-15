using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amulet : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.name == "EyeCameraMainCol" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 0;
            Invoke("AmuletEnd",6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRightCol" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 1;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraLeftCol" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 2;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRoom1Col" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 3;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRoom2Col" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 4;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRoom3Col" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 5;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRoom4Col" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 6;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRoom5Col" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 7;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
        if (this.gameObject.name == "EyeCameraRoom6Col" && other.gameObject.CompareTag("Amulet"))
        {
            SkillCost.amuletOn = true;
            SkillCost.amuletBool = 8;
            Invoke("AmuletEnd", 6);
            Destroy(other.gameObject);
        }
    }
    void AmuletEnd()
    {
        SkillCost.amuletOn = false;
        SkillCost.amuletBool = 99;
    }
}
