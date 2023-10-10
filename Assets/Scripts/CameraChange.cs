using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour
{
    int cameraChangeCount;
    public RawImage rawImage;

    public RenderTexture[] rt;
    void Start()
    {
        cameraChangeCount = 0;
    }
    void Update()
    {
        switch (cameraChangeCount)
        {
            case 0: rawImage.texture = rt[0]; break;
            case 1: rawImage.texture = rt[1]; break;
            case 2: rawImage.texture = rt[2]; break;
            case 3: rawImage.texture = rt[3]; break;
            case 4: rawImage.texture = rt[4]; break;
            case 5: rawImage.texture = rt[5]; break;
        }
    }
    public void CameraChangeRight()
    {
        cameraChangeCount--;
        if(cameraChangeCount < 0)
        {
            cameraChangeCount = 5;
        }
    }
    public void CameraChangeLeft()
    {
        cameraChangeCount++;
        if(cameraChangeCount > 5)
        {
            cameraChangeCount = 0;
        }
    }
}
