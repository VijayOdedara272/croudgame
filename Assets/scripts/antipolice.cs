using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antipolice : MonoBehaviour
{
    GameObject croud;
    [SerializeField] float speed;
    [SerializeField] float distence;
    [SerializeField] collider colliderscript;

    private void Start()
    {
        croud = GameObject.Find("croud");
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(croud.transform.position.z - transform.position.z) < distence)
        {
            transform.position = Vector3.MoveTowards(transform.position, croud.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "police")
        {

            colliderscript.SplashandParticle(col.gameObject);
            Destroy(gameObject);
        }
    }
}
