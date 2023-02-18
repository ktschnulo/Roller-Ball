using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockController : MonoBehaviour
{
    public GameObject linkedKey;

    // Update is called once per frame
    void Update()
    {
        if (linkedKey.activeSelf == false)
        {
            this.gameObject.SetActive(false);
        }
    }
}
