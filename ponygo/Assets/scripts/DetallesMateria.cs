using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetallesMateria : MonoBehaviour {

    public Text Nombre;
    public Image Img;
    int Imagen;
    public Text Descripcion;
    public Text Value;
    public Text Semester;
    public Texture[] texturas;

    // Use this for initialization
    void Start()
    {

    }

    public void Crear(Materia materia)
    {
        Nombre.text = materia.Nombre;

        string caseSwitch = materia.Imagen;

        Debug.Log(caseSwitch);
        switch (caseSwitch)
        {
            case "0":
                Img.material.mainTexture = texturas[0];
                break;
            case "1":
                Img.material.mainTexture = texturas[1];

                break;
            case "2":
                Img.material.mainTexture = texturas[2];

                break;
            case "3":
                Img.material.mainTexture = texturas[3];

                break;
            case "4":
                Img.material.mainTexture = texturas[4];

                break;
            case "5":
                Img.material.mainTexture = texturas[5];

                break;
            case "":
                Img.material.mainTexture = texturas[2];

                break;
            default:
                Img.material.mainTexture = texturas[1];

                break;
        }



        Descripcion.text = materia.Descripcion;
        Value.text = materia.Value;
        Semester.text = materia.Semester;
    }
}

