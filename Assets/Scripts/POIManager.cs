using Mapbox.BaseModule.Data.Vector2d;
using Mapbox.BaseModule.Map;
using Mapbox.BaseModule.Utilities;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class POIData
{
    public GameObject prefab;
    public double latitude;
    public double longitude;
}

public class POIManager : MonoBehaviour
{
    public MapBehaviourCore mapCore;
    public List<POIData> pois = new List<POIData>();

    private void Awake()
    {
        mapCore.Initialized += CreatePOIs;
    }

    private void CreatePOIs(MapboxMap map)
    {
        foreach (POIData data in pois)
        {
            LatitudeLongitude coordinates =
                new LatitudeLongitude(data.latitude, data.longitude);

            Vector3 position =
                map.MapInformation.ConvertLatLngToPosition(coordinates);

            GameObject poi =
                Instantiate(data.prefab, map.UnityContext.MapRoot);

            poi.transform.localPosition = position;
        }
    }
}