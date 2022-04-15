using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endline : MonoBehaviour
{
    [SerializeField] controller controller;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "croud")
        {
            controller.winner();
        }
    }
}
