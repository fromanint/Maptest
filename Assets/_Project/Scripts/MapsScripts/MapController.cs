using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using ARLocation;


public class MapController : MonoBehaviour
{

     public enum LineType
        {
            Route,
            NextTarget
        }

        public string MapboxToken = "pk.eyJ1IjoiZG1iZm0iLCJhIjoiY2tyYW9hdGMwNGt6dTJ2bzhieDg3NGJxNyJ9.qaQsMUbyu4iARFe0XB2SWg";
        public GameObject ARSession;
        public GameObject ARSessionOrigin;
        public GameObject RouteContainer;
        public Camera Camera;
        public Camera MapboxMapCamera;
        public MapboxRoute MapboxRoute;
        public AbstractRouteRenderer RoutePathRenderer;
        public AbstractRouteRenderer NextTargetPathRenderer;
        public Texture RenderTexture;
        public Mapbox.Unity.Map.AbstractMap Map;
        [Range(100, 800)]
        public int MapSize = 400;
        public DirectionsFactory DirectionsFactory;
        public int MinimapLayer;
        public Material MinimapLineMaterial;
        public float BaseLineWidth = 2;
        public float MinimapStepSize = 0.5f;

        private AbstractRouteRenderer currentPathRenderer => s.LineType == LineType.Route ? RoutePathRenderer : NextTargetPathRenderer;

        public LineType PathRendererType
        {
            get => s.LineType;
            set
            {
                if (value != s.LineType)
                {
                    currentPathRenderer.enabled = false;
                    s.LineType = value;
                    currentPathRenderer.enabled = true;

                    if (s.View == View.Route)
                    {
                        MapboxRoute.RoutePathRenderer = currentPathRenderer;
                    }
                }
            }
        }

        enum View
        {
            SearchMenu,
            Route,
        }

        [System.Serializable]
        private class State
        {
            public string QueryText = "";
            public List<GeocodingFeature> Results = new List<GeocodingFeature>();
            public View View = View.SearchMenu;
            public Location destination;
            public LineType LineType = LineType.NextTarget;
            public string ErrorMessage;
        }

        private State s = new State();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /
}
