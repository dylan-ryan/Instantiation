using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CuberGenerator : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject newObject = GameObject.Instantiate(prefab); // use this
        GameObject newObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        newObject.AddComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
