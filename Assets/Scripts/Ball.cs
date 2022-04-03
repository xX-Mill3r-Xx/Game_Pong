using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        float sX = Random.Range(0, 2) == 0 ? -1 : 1;
        float sY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sX, speed * sY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
