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
        if (other.gameObject.CompareTag("Fetish"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("ResultScene");
        }
    }
}
