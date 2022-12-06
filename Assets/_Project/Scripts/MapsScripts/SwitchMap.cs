using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMap : MonoBehaviour
{
    public Camera mapCamera;

    public RenderTexture mapRenderTexture;


    void Start()
    {
        mapRenderTexture = mapCamera.targetTexture;
    }


    public void MiniMapView()
    {
        mapCamera.targetTexture = mapRenderTexture;
    }

    public void MapView()
    {
        mapCamera.targetTexture = null;
    }
}
