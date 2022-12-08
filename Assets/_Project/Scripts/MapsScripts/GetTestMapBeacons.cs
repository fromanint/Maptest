using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using ARLocation.MapboxRoutes.SampleProject;
public class GetTestMapBeacons : MonoBehaviour
{

	[SerializeField]
	AbstractMap _map;

	[SerializeField]
	MapController mapController;

	[SerializeField]
	[Geocode]
	string[] _locationStrings;
	Vector2d[] _locations;

	[SerializeField]
	float _spawnScale = 100f;

	[SerializeField]
	UpdateBeaconLocation _markerPrefab;

	List<UpdateBeaconLocation> _spawnedObjects;

	void Start()
	{
		_locations = new Vector2d[_locationStrings.Length];
		_spawnedObjects = new List<UpdateBeaconLocation>();
		for (int i = 0; i < _locationStrings.Length; i++)
		{
			var locationString = _locationStrings[i];
			_locations[i] = Conversions.StringToLatLon(locationString);
			var instance = Instantiate(_markerPrefab);
			instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
			instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
			instance.location = _locations[i];
			instance._map = _map;
			instance.controller = mapController;
			instance._spawnScale = _spawnScale;
			_spawnedObjects.Add(instance);
			

		}
	}

	private void Update()
	{
		
	}
}
   




