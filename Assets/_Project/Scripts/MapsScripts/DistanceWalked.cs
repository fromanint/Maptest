using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ARLocation;
using TMPro;


public class DistanceWalked : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI distanceWalked;
    public double distance;

    private ARLocationProvider locationProvider;

    void Start()
    {
        distance = PlayerPrefs.GetFloat("DistanceWalked", 0);
        distanceWalked.text = distance.ToString();
        locationProvider = ARLocationProvider.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        //distance += locationProvider.Provider.DistanceFromStartPoint;
        //float dis = (float)distance;
        //distanceWalked.text = distance.ToString();

        float dis = (float)distance + (float)locationProvider.Provider.DistanceFromStartPoint;
        distanceWalked.text = dis.ToString("F2");
        PlayerPrefs.SetFloat("DistanceWalked", dis);
    }
}
