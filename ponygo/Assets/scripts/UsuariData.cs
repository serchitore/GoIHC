using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsuariData : MonoBehaviour {
    public Text nameUser;

    // Use this for initialization
    private void Start () {
        if (DBManager.loggedIn)
        {
            nameUser.text = DBManager.username;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
