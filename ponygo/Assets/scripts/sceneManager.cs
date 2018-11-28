using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class sceneManager : MonoBehaviour
{

    [SerializeField] private GameObject m_registerUI = null;
    [SerializeField] private GameObject m_loginUI = null;


    public void Cargajuego()
    {

        SceneManager.LoadScene(0);
    }

    public void showLogin()
    {
        m_registerUI.SetActive(false);
        m_loginUI.SetActive(true);
    }
    public void showRegister()
    {
        m_registerUI.SetActive(true);
        m_loginUI.SetActive(false);
    }
   
    public void CargaPony()
    {

        SceneManager.LoadScene(2);
    }
    public void CargaMapa()
    {

        SceneManager.LoadScene(3);
    }
    public void Cargalogros()
    {

        SceneManager.LoadScene(3);
    }
    public void CargaAsistente()
    {

        SceneManager.LoadScene(4);
    }
    public void Salirasistente()
    {

        SceneManager.LoadScene(1);
    }

}
