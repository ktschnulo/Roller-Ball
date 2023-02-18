using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Point2PointPlatform : MonoBehaviour
{
    [SerializeField] Transform platform;
    [SerializeField] Transform startingLocation;
    [SerializeField] Transform endingLocation;
    public float movementSpeed = 3.0f;
    public bool isOn = true;
    //public bool isConstant = false;
    public bool moveOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        platform.position = startingLocation.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOn == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startingLocation.position, movementSpeed * Time.deltaTime);
        }
        else if (isOn == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, endingLocation.position, movementSpeed * Time.deltaTime);
        }

        if (transform.position == startingLocation.position)
        {
            isOn = true;
        }
        else if (transform.position == endingLocation.position)
        {
            if (moveOnce == false)
            {
                isOn = false;
            }
            if (moveOnce == true)
            {
                isOn = true;
            }
        }
    }
}
