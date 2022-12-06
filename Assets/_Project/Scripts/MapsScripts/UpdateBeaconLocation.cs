
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using ARLocation.MapboxRoutes.SampleProject;
using ARLocation;



public class UpdateBeaconLocation : MonoBehaviour
{



    public AbstractMap _map;
    public MenuH3MBaseMap menuController;



    public Vector2d location;

    public float _spawnScale = 100f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        transform.localPosition = _map.GeoToWorldPosition(location, true);
        transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);


    }

    public void StartRouting()
    {
        
        Location newLoc = new Location(location.x,location.y);
        menuController.StartRoute(newLoc);
            
    }


    
}