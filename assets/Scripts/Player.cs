using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string nombre = "Pepito";
    public int health = 100;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The game has started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pepitear();
        }
    }

    void pepitear()
    {
        Debug.Log("El jugador ha atacado");
    }
}
