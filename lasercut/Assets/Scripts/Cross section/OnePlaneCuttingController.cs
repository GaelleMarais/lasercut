using UnityEngine;
using System.Collections.Generic;

public class OnePlaneCuttingController : MonoBehaviour {

    public GameObject plane;
    Material mat;
    public Vector3 normal;
    public Vector3 position;
    public bool inversedZAxis = false;
    private List<Renderer> rendererList = new List<Renderer>();
    private int Zaxe;

    void Start () {

        foreach (Renderer objectRenderer in GetComponentsInChildren<Renderer>())        
            rendererList.Add(objectRenderer);
        Zaxe = inversedZAxis ? 1 : -1;
        normal = plane.transform.TransformVector(new Vector3(0,0, Zaxe));
        position = plane.transform.position;
        UpdateShaderProperties();
    }
    void Update ()
    {
        UpdateShaderProperties();
    }

    private void UpdateShaderProperties()
    {
        normal = plane.transform.TransformVector(new Vector3(0, 0, Zaxe));
        position = plane.transform.position;

        foreach (Renderer rend in rendererList)
        {
            foreach (Material m in rend.materials)
            {
                m.SetVector("_PlaneNormal", normal);
                m.SetVector("_PlanePosition", position);
            }
        }
    }
}
