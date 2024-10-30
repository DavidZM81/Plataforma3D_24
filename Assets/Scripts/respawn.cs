using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private float caida = -20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (transform.position.y < caida)

        {

            transform.position = new Vector3(3.1f, 0.683f, -44.863f);

        }
    }
}
