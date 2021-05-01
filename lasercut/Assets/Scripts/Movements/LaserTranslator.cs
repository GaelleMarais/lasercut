using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTranslator : MonoBehaviour
{
    public float sensitivity = 0.005f;
    private Vector3 _min;
    private Vector3 _max;
    private Vector3 _translation;


    // Start is called before the first frame update
    void Start()
    {
        _translation = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            TranslateZ(1);
        }

        if (Input.GetKey("left"))
        {
            TranslateZ(-1);
        }
    }

    void TranslateZ(float translation)
    {
        transform.Translate(0, 0, translation * sensitivity);
    }
}
