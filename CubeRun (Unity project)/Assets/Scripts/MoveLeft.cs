using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject character;
    public GameObject cylinder;
    public float speed = -2f;

    void Start()
    {
        ispressed = false;
        character.transform.position = new Vector3(0f, -20f, 43.9f);
    }

    void Update()
    {
        character.transform.position = new Vector3(0f, -20f, 43.9f);

        if (!ispressed)
            return;
        // DO SOMETHING HERE
        cylinder.transform.Rotate(0, -5f, 0, Space.World);
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
