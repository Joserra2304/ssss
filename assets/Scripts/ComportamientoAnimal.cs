using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoAnimal : MonoBehaviour
{
    public string animalSound = "Desconocido";
    public Color color = Color.red;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log(animalSound);
        }
    }
}
