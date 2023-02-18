using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBlockDeleter : MonoBehaviour
{
    //variables
    public float threshold = 79f;
    public bool deleterOn = false;

    // Update is called once per frame
    void Update()
    {
        if (deleterOn == true && transform.position.z < threshold)
        {
            Destroy(this.gameObject);
        }
    }
}
