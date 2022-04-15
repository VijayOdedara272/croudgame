using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antipolicespawner : MonoBehaviour
{
    [SerializeField] GameObject antipoliceobj;
    [SerializeField] TextMesh textmesh;
    [SerializeField] float spawncount;

    private void Start()
    {

        for (int i = 1; i <= spawncount; i++)
        {
            float offset1 = Random.Range(0.4f, 1f);
            float offset2 = Random.Range(0.4f, 1f);
            Vector3 pos = new Vector3(gameObject.transform.position.x + offset1, gameObject.transform.position.y, gameObject.transform.position.z + offset2);

            Instantiate(antipoliceobj, pos, antipoliceobj.transform.rotation, gameObject.transform);
        }
    }

    private void Update()
    {
        int counter = gameObject.transform.childCount - 1;
        textmesh.text = counter.ToString();
        if(counter == 0)
        {
            Destroy(gameObject);
        }
    }
}
