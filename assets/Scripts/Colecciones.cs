using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecciones : MonoBehaviour
{

    //ARRAYS: estructuras estáticas que guardan solamente un tipo de dato
    public string[] listaFijaJugadores = new string[3];
    public string[] listaFijaJugadores2 = { "Pepito", "Juanito", "Carlitos" };
    public string[] listaFijaJugadores3 = new string[] { "Pepito", "Juanito", "Carlitos" };


    void array()
    {
 
       string firstName = listaFijaJugadores2[0];
       Debug.Log(firstName);
        firstName = "Jesus";
        Debug.Log(firstName);

    }

    //LISTAS: estructuras que guardan un solo tipo de dato pero manipulable, añadiendo y eliminando elementos
    public List<string> listaDinamicaEnemigos = new List<string>();
    public List<string> listaDinamicaEnemgos2 = new List<string> {"Malito", "Tontito", "Cuajado"};

    //ARRAYLIST: estructuras que pueden guardar cualquier tipo de dato.
    public ArrayList userInfo = new ArrayList();

    //DICCIONARIOS: hash table

    public Hashtable personalInfo = new Hashtable();




    void Awake()
    {
        array();
        listaDinamicaEnemigos.Add("Idiota");

        userInfo.Add(10);
        userInfo.Add("José");
        userInfo.Add("Cydonian");
        userInfo.Add(31);
        userInfo.Add(1.75f);
        userInfo.Add(GameObject.Find("Capsule"));

        Debug.Log(userInfo[2] + ", " + userInfo[2].GetType());
        Debug.Log(userInfo[4] + ", " + userInfo[4].GetType());
        Debug.Log(userInfo[0] + ", " + userInfo[0].GetType());

        personalInfo.Add("userLevel", 10);
        personalInfo.Add("playerName", "Jose");
        personalInfo.Add("userName", "Cydonian");
        personalInfo.Add("age", 31);
        personalInfo.Add("height", 1.75f);
        personalInfo.Add("playerObject", GameObject.Find("Capsule"));

        Debug.Log((string) personalInfo["userName"]);

        int edad = (int) personalInfo["age"];

        if (personalInfo.Contains("userName"))
        {
            Debug.Log("El nombre de usuario es " + (string)personalInfo["userName"]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        listaDinamicaEnemigos.Add("Gilipollas");

        if (listaDinamicaEnemigos.Contains("Idiota"))
        {
            Debug.Log("Hay un idiota en el juego");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            listaDinamicaEnemigos.Remove("Idiota");
            
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            listaDinamicaEnemgos2.Clear();

        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            listaDinamicaEnemgos2.Insert(1,"Boss");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            listaDinamicaEnemgos2.ToArray();
        }

    }
}
