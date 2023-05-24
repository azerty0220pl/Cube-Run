using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject character;
    public GameObject cylinder;
    public float speed = 10f;

    void Start()
    {
        ispressed = false;
        speed = 10f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cylinder.transform.Rotate(0, 5f, 0, Space.World);
        }
        if (!ispressed)
            return;
        // DO SOMETHING HERE
        cylinder.transform.Rotate(0, 5, 0, Space.World);
        //character.transform.position = new Vector3(0f, -20f, 43.9f);
    }
    public bool ispressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
