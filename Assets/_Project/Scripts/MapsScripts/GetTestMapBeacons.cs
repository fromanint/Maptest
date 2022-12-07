using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ARLocation;
using Mapbox.Unity.Map;
using ARLocation.MapboxRoutes.SampleProject;

public class GetTestMapBeacons : MonoBehaviour
{

    public AbstractMap _map;

    public MapController mapController;
    public Transform beaconsParent;

    public UpdateBeaconLocation markerPrefab;

    public List<UpdateBeaconLocation> markers;

    public List<Location> testCoordinates;

    public int locationsNumber = 5;

    public string providerStatusStarted = "Started";

    public float beaconsSize = 3f;


    private ARLocationProvider locationProvider;
    // Start is called before the first frame update
    IEnumerator Start()
    {

        locationProvider = ARLocationProvider.Instance;

        while (locationProvider.Provider.GetStatusString() != providerStatusStarted)
            yield return null;
        
        for (int i = 0; i < locationsNumber; i++)
        {
            double Latitude = Random.Range(-1000, 1000);
            double Longitude = Random.Range(-1000, 1000);
            //double Latitude = rdn
            Latitude = (Latitude / 100000)+ locationProvider.CurrentLocation.latitude;
            Longitude = (Longitude / 100000) + locationProvider.CurrentLocation.longitude;


            Location loc = new Location(Latitude, Longitude, +locationProvider.CurrentLocation.altitude);
            testCoordinates.Add(loc);

            UpdateBeaconLocation beacon = Instantiate(markerPrefab);
            beacon.location.x = Latitude;
            beacon.location.y = Longitude;
            beacon.transform.parent = beaconsParent;
            beacon._spawnScale = beaconsSize;
            beacon.gameObject.name = "Beacon " + i;
            beacon.controller = mapController;
            beacon._map = _map;
            

        }

        

    }

   



}
