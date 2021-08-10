using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    private GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Camera.transform.position.z > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
