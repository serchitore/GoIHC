using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{

    public InputField inputN;
    public InputField inputP;



    string loginUserURL = "http://localhost/loginControl/serverunity/login.php";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Logear()
    {
        StartCoroutine(LoginToDB(inputN.text, inputP.text));
    }

    IEnumerator LoginToDB(string inputN, string inputP)
    {
        WWWForm form = new WWWForm();
        form.AddField("inputn", inputN);
        form.AddField("inputp", inputP);

        WWW www = new WWW(loginUserURL, form);

        yield return www;

        Debug.Log(www.text);

        if (www.text.Equals("login success"))
        {
            SceneManager.LoadScene(1);
        }
        else if (www.text.Equals("user not found"))
        {

        }
        else
        {

        }

    }

}

