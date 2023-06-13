using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour
{
    public GameObject gameObject1;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector3 = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = gameObject1.transform.position;
        transform.position = vector3;
    }
}