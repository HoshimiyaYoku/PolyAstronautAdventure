using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsSpwan : MonoBehaviour
{
    public GameObject stars;
    public GameObject player;
    Vector3 vector = new Vector3();
    Vector3 pvector = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        vector.x = 0;
        vector.y = 0;
        vector.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pvector = player.transform.position;
        if(Vector3.Distance(vector,pvector) >= 20f)
        {
            vector = pvector;
            pvector.z += 13f;
            pvector.x += 10f;
            pvector.y += 10f;
            Instantiate(stars, pvector, Quaternion.identity);

        }
    }
}
