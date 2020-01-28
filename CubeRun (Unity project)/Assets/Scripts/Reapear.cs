using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reapear : MonoBehaviour
{
    float speed;

    // Update is called once per frame
    void Update()
    {
        speed = PlayerPrefs.GetFloat("speed");
        float pos = transform.position.y - speed;
        transform.position = new Vector3(0f, pos, 50f);
        if (transform.position.y <= -40)
        {
            transform.position = new Vector3(0f, transform.position.y + 120f, 50f);
        }
    }
}
