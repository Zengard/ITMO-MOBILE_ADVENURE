using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryTest : MonoBehaviour
{
    public GameObject bugObject;

    // Start is called before the first frame update
    void Start()
    {
        bugObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
