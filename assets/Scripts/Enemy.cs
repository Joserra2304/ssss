using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string nombre = "Malito";
    public int health = 50;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Let's finish it");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            malitear();
        }
    }

    void malitear()
    {
        Debug.Log("El enemigo ha atacado");
    }
}
