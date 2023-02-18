using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject lock1;
    public GameObject lock2;
    public GameObject openDoor;

    // Update is called once per frame
    void Update()
    {
        if (lock1.activeSelf == false && lock2.activeSelf == false)
        {
            Instantiate(openDoor, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
