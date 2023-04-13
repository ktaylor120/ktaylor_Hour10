using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValocityScript : MonoBehaviour
{
    public float startSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(startSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
