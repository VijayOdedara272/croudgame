using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policespawner : MonoBehaviour
{

    int increment;
    GameObject croud;
    [SerializeField] GameObject police;
    [SerializeField]TextMesh textmesh;
    int multiplication = 1;
    int croudchild;



    private void Awake()
    {
        int variation;
        variation = (int) Random.Range(1, 5);

        croud = GameObject.Find("croud");

        if (variation == 2 || variation == 5)
        {
            multiplication = (int) Random.Range(2, 5);
            textmesh.text = multiplication.ToString() + "x";
            croudchild = croud.transform.childCount;
            increment = (croudchild * multiplication) - croudchild;
        }
        else
        {
            increment = (int)Random.Range(10, 60);
            multiplication = 1;
            textmesh.text = increment.ToString() + "+";
        }

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "croud")
        {

            for ( int i = 1; i <= increment; i++ )
            {
                float offset1 = Random.Range(0.4f, 1f);
                float offset2 = Random.Range(0.4f, 1f);
                Vector3 pos = new Vector3(croud.transform.position.x + offset1, croud.transform.position.y, croud.transform.position.z + offset2);

                Instantiate(police,pos, Quaternion.identity, croud.transform);
            }
        }
    }
}
