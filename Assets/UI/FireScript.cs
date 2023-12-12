using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
       gameObject.GetComponent<Animator>().SetBool("UICostBool", true);
    }
    public void CostSet2()
    {
        gameObject.GetComponent<Animator>().SetBool("UICostBool", false);

        Invoke("aaa",2);
    }

    void aaa()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
