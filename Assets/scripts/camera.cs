using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject cam;
    GameObject croud;
    [SerializeField] Vector3 offset;
    [SerializeField] TextMesh countertxt;

    void Awake()
    {
        croud = GameObject.Find("croud");
        cam = gameObject;
    }

    
    void Update()
    {
        cam.transform.position = croud.transform.position + offset;
        int counter = croud.transform.childCount - 2;
        countertxt.text = counter.ToString();
    }
}
