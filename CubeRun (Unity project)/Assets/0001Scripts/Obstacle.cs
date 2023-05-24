using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject cubes;
    public GameObject spheres;
    public GameObject cubesDifficult;
    GameObject character;
    float rotation;
    int obstacle;
    float cubeRot;
    float sphereRot;
    float difficultRot;
    int easy;
    int medium;
    float position;

    private void Start()
    {
        character = GameObject.Find("Character");
    }

    private void Update()
    {
        position = character.transform.position.z;

        if (spheres.activeInHierarchy == true)
        {
            //rotation = Random.Range(-1.5f, 1.5f);
            transform.Rotate(0f, sphereRot, 0f, Space.World);
        }

        if (position <= 41)
        {
            spheres.SetActive(false);
            cubes.SetActive(false);
            cubesDifficult.SetActive(false);
        }

        if(transform.position.y >= 65)
        {
            easy = PlayerPrefs.GetInt("easy");
            medium = PlayerPrefs.GetInt("medium");
            obstacle = Random.Range(1, 100);
            if (obstacle >= 1 && obstacle <= easy)
            {
                cubes.SetActive(true);
                spheres.SetActive(false);
                cubesDifficult.SetActive(false);
            }
            else if (obstacle > easy && obstacle <= medium)
            {
                cubes.SetActive(false);
                spheres.SetActive(true);
                cubesDifficult.SetActive(false);
                sphereRot = Random.Range(-1.5f, 1.5f);
                //transform.Rotate(0f, rotation, 0f, Space.World);
            }
            else if (obstacle > medium)
            {
                cubes.SetActive(false);
                spheres.SetActive(false);
                cubesDifficult.SetActive(true);
            }

            rotation = Random.Range(0, 359);
            transform.eulerAngles = new Vector3(0f, rotation, 0f);
            //Debug.Log("Main has been rotated");
        }
    }
}
