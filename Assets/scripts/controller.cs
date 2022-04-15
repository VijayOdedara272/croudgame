using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject playbtn;
    [SerializeField] GameObject restarttxt;
    [SerializeField] GameObject restartbtn;
    [SerializeField] GameObject croud;
    [SerializeField] GameObject platformbound1;
    [SerializeField] GameObject platformbound2;
    [SerializeField]float speed = 1f;
    [SerializeField] float offset = 1f;
    [Range(1f , 30f)] [SerializeField] float sensivity;
    Rigidbody rb;
    private Vector3 lastMousePos;
    
    void Start()
    {
        //rb = croud.GetComponent<Rigidbody>();
        Time.timeScale = 0f;
    }


    void FixedUpdate()
    {
        if(croud.transform.childCount == 2)
        {
            restarttxt.SetActive(true);
            restartbtn.SetActive(true);
            Time.timeScale = 0f;
        }

        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 vector = lastMousePos - Input.mousePosition;
            lastMousePos = Input.mousePosition;
            vector = new Vector3(vector.x, 0, 0);

            croud.transform.position += -vector * speed * sensivity * Time.deltaTime;
            Vector3 pos = new Vector3(Mathf.Clamp(croud.transform.position.x, platformbound1.transform.position.x + offset, platformbound2.transform.position.x - offset - offset) , croud.transform.position.y , croud.transform.position.z);
            croud.transform.position = pos;
        }

        croud.transform.Translate(Vector3.forward * speed, Space.World);
        //rb.AddForce(Vector3.forward * speed);
 
    }

    public void play()
    {
        Time.timeScale = 1f;
        playbtn.SetActive(false);

    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void winner()
    {
        restarttxt.SetActive(true);
        restarttxt.GetComponent<Text>().text = "Winner";
        restartbtn.SetActive(true);
        Time.timeScale = 0f;
    }


}
