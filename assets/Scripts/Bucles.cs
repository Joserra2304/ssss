using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public string[] listaFijaJugadores2 = { "Pepito", "Juanito", "Carlitos" };
    public Hashtable personalInfo = new Hashtable();

    void Awake(){
        //FOR EACH
        foreach (string personaje in listaFijaJugadores2){
            Debug.Log(personaje);
        }

        personalInfo.Add("userLevel", 10);
        personalInfo.Add("playerName", "Jose");
        personalInfo.Add("userName", "Cydonian");
        personalInfo.Add("age", 31);
        personalInfo.Add("height", 1.75f);

        foreach (string clave in personalInfo.Keys)
        {
            Debug.Log(clave + ": "+ personalInfo[clave]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
