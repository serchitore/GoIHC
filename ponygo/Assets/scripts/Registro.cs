using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registro : MonoBehaviour
{

    string CreateUserURL = "http://localhost/loginControl/serverunity/createUser.php";
    public InputField usernameInput;
    public InputField passInput;
    public InputField repassInput;
    public InputField oldInput;
    public Text estatus;

    public Button registro;

    public void callRegister()
    {
        if (usernameInput.text.Equals("")  || passInput.text.Equals("") || repassInput.text.Equals("") || oldInput.text.Equals(""))
        {
            estatus.text = "Verify that all fields are full";

        }
        else
        {
            if (passInput.text == repassInput.text )
            {
                StartCoroutine(Register());
            }
            else
            {
                estatus.text = "Passwords do not match";
            }
        }
        
        
    }

   IEnumerator Register() {

        WWWForm form = new WWWForm();
        form.AddField("userpost", usernameInput.text);
        form.AddField("passpost", passInput.text);
        form.AddField("oldpost", oldInput.text);

        WWW www= new WWW("http://localhost/loginControl/serverunity/createUser.php", form);
        yield return www;

        if (www.text.Equals("user available"))
        {
            estatus.text = "Account Created successfully";
        }
        else if (www.text.Equals("username in use"))
        {
            estatus.text = "username in use";
        }
       

    }

    public void verificaInput()
    {
        if (passInput.text.Length >= 5)
        {
            repassInput.interactable = true;
            estatus.text = "";

        }
        else
        {
            estatus.text = "the password must contain more than 5 characters";
            repassInput.interactable = false;

        }
    }
    
}
