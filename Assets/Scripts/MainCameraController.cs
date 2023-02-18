using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    //variables
    public GameObject player;
    private Vector3 offset;

    public float speedH = 1.0f;
    public float speedV = 1.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
}
