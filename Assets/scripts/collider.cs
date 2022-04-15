using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    [SerializeField] ParticleSystem particalsys;
    [SerializeField] GameObject splash;


    private void OnTriggerEnter(Collider col)
    {

        SplashandParticle(col.gameObject);
    }

    public void SplashandParticle(GameObject col)
    {
        ParticleSystem ps = Instantiate(particalsys, col.transform.position, Quaternion.identity);
        Vector3 pos = new Vector3(col.transform.position.x, splash.transform.position.y, col.transform.position.z);
        GameObject splashobj = Instantiate(splash, pos, splash.transform.rotation);
        Destroy(col.gameObject);
        Destroy(ps.gameObject, 1f);
        Destroy(splashobj.gameObject, 4f);
    }

}
