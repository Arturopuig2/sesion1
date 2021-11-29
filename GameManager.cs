using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*
     * NO SÉ LA DIFERENCIA ENTRE PONER LAS VARIABLES DENTRO DEL MÉTODO O FUERA. 
     */

    //Declaro los GO Fighter
   // public Fighter Cubo1;
    //public Fighter Cubo2;
    //public Fighter Cubo3;
    //public Fighter Cubo4;
    //public Fighter Cubo5;

    //Declaro una lista de GO.
    //public GameObject[] list;

    //Declaro una lista de nombres y categorías.
    //public List<string> nombres;
    //public List<string> categorias;

    //Declaro la variable salud.
    //public int salud;

    public void InitFighters()
    {
        //Creo la lista de GameObjects en la que voy a meter a todos los GO que tengan el tag "luchador"
       GameObject[] list = GameObject.FindGameObjectsWithTag("luchador");

        Debug.Log("Nº de luchadores: " + list.Length);

        //Asigno. "El componente de tipo Fighter en la posición 0 de la lista será Cubo1"
        Fighter Cubo1 = list[0].GetComponent<Fighter>();
        Fighter Cubo2 = list[1].GetComponent<Fighter>();
        Fighter Cubo3 = list[2].GetComponent<Fighter>();
        Fighter Cubo4 = list[3].GetComponent<Fighter>();
        Fighter Cubo5 = list[4].GetComponent<Fighter>();

        //Creo las listas de atributos
        List<string> nombres = new List<string>() { "Scorpion", "Kano", "Sonya", "Johnny Cage", "Sub-Zero" };
        List<string> categorias = new List<string>() { "Ninja", "Mercenario", "Teniente", "Actor", "Ninja" };
        int salud = 100;

        //Asigno atributos

        Cubo1.GetComponent<Fighter>().name = nombres[0];
        //Cubo1.name = nombres[0];
        Cubo2.name = nombres[1];
        Cubo3.name = nombres[2];
        Cubo4.name = nombres[3];
        Cubo5.name = nombres[4];
        Cubo1.category = categorias[0];
        Cubo2.category = categorias[1];
        Cubo3.category = categorias[2];
        Cubo4.category = categorias[3];
        Cubo5.category = categorias[4];
        Cubo1.health = salud;
        Cubo2.health = salud;
        Cubo3.health = salud;
        Cubo4.health = salud;
        Cubo5.health = salud;

        Debug.Log("Luchador 1.\n Nombre: " + Cubo1.name + " Categoría: " + Cubo1.category + " Salud: " + Cubo1.health);
        Debug.Log("Luchador 2.\n Nombre: " + Cubo2.name + " Categoría: " + Cubo2.category + " Salud: " + Cubo2.health);
        Debug.Log("Luchador 3.\n Nombre: " + Cubo3.name + " Categoría: " + Cubo3.category + " Salud: " + Cubo3.health);
        Debug.Log("Luchador 4.\n Nombre: " + Cubo4.name + " Categoría: " + Cubo4.category + " Salud: " + Cubo4.health);
        Debug.Log("Luchador 5.\n Nombre: " + Cubo5.name + " Categoría: " + Cubo5.category + " Salud: " + Cubo5.health);
    }

    // Start is called before the first frame update
    void Start()
    {
        InitFighters();
    }

    void Update()
    {
        
    }
}
