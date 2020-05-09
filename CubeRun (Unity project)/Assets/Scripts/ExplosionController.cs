using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public GameObject explosion;
    public GameObject character;
    void Update()
    {
        if (PlayerPrefs.GetInt("state") == 0)
        {
            character.SetActive(false);
            explosion.SetActive(true);
        }
        else
        {
            character.SetActive(true);
            explosion.SetActive(false);
        }
    }
}
