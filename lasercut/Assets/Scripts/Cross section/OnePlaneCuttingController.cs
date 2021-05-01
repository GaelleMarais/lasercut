using UnityEngine;
using System.Collections.Generic;

public class OnePlaneCuttingController : MonoBehaviour {

    public GameObject plane;
    Material mat;
    public Vector3 normal;
    public Vector3 position;
    private List<Renderer> rendererList = new List<Renderer>();

    void Start () {

        foreach (Renderer objectRenderer in GetComponentsInChildren<Renderer>())        
            rendererList.Add(objectRenderer);
        
        normal = plane.transform.TransformVector(new Vector3(0,0,-1));
        position = plane.transform.position;
        UpdateShaderProperties();
    }
    void Update ()
    {
        UpdateShaderProperties();
    }

    private void UpdateShaderProperties()
    {
        normal = plane.transform.TransformVector(new Vector3(0, 0, -1));
        position = plane.transform.position;

        foreach (Renderer rend in rendererList)
        {
            rend.material.SetVector("_PlaneNormal", normal);
            rend.material.SetVector("_PlanePosition", position);
        }
    }
}
