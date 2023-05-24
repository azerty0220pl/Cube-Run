using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject character;
    Touch touch;
    float touchPosition1;
    float touchPosition2;
    float moving;

    void Start()
    {
        //ispressed = false;
        character.transform.position = new Vector3(0f, -20f, 43.9f);
    }

    private void Update()
    {
        character.transform.position = new Vector3(0f, -20f, 43.9f);
        if (Input.touchCount != 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
                touchPosition1 = touch.position.x;

            if (touch.phase == TouchPhase.Moved)
            {
                touchPosition2 = moving = touch.position.x;
                moving = touchPosition2 - touchPosition1;
                //moving = moving + cylinder.transform.rotation.y;
                moving = moving / 4f;
                // moving = Mathf.RoundToInt(moving);
                cylinder.transform.Rotate(0f, moving, 0f, Space.World);
                touchPosition1 = touchPosition2;
            }
        }
        else if (Input.touchCount == 0)
        {
            touchPosition1 = 0;
            touchPosition2 = 0;
        }
    }


}
