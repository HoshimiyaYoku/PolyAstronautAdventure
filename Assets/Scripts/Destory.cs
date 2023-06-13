using UnityEngine;
using System.Collections;

public class Destory : MonoBehaviour
{
    Vector3 vector = new Vector3();
    public GameObject palyer;
    void Start()
    {
        vector = transform.position;
    }
    void Update()
    {
        if(Vector3.Distance(vector,palyer.transform.position) > 50f)
        {
            Destroy(gameObject);
        }
    }
}