using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Materia 
{
    public string Nombre;
    //public Sprite Imagen;
    public string Imagen;
    public string Descripcion;
    public string Value;
    public string Semester;


}
public class Lista : MonoBehaviour
{



        public string calculo;
        public Sprite fprogra;
        public Sprite md1;
        public Sprite itics;

    public GameObject PrefabMateria;
        public Transform Contenedor;

        // Use this for initialization
        void Start()
        {
        StartCoroutine(DATA());

        }

    IEnumerator DATA()
    {
        WWW www = new WWW("http://localhost/loginControl/serverunity/consumo.php");
        yield return www;

        WWW wwws = new WWW("http://localhost/loginControl/serverunity/consumosemestre.php");

        yield return wwws;
        WWW wwwn = new WWW("http://localhost/loginControl/serverunity/consumonivel.php");

        yield return wwwn;

        WWW wwwi = new WWW("http://localhost/loginControl/serverunity/consumoimg.php");

        yield return wwwi;


        WWW wwwd = new WWW("http://localhost/loginControl/serverunity/consumodetalle.php");

        yield return wwwd;


        string result = www.text;
        string[] separadas;
        separadas = result.Split(',');

        string result2 = wwws.text;
        string[] separadas2;
        separadas2 = result2.Split(',');

        string result3 = wwwn.text;
        string[] separadas3;
        separadas3 = result3.Split(',');

        string result4 = wwwi.text;
        string[] separadas4;
        separadas4 = result4.Split(',');


        string result5 = wwwd.text;
        string[] separadas5;
        separadas5 = result5.Split(';');









        for (int i = 0; i <= separadas.Length ; i++)
        {

            List<Materia> LMat = new List<Materia> {
            new Materia{Nombre= separadas[i], Semester= separadas2[i], Value=separadas3[i], Imagen=separadas4[i], Descripcion= separadas5[i] }

        };

            foreach (var item in LMat)
            {
                GameObject materia = Instantiate(PrefabMateria, Contenedor);
                materia.GetComponent<DetallesMateria>().Crear(item);
            }


  }
    }

    


    // Update is called once per frame
    void Update()
        {

        }
    }

