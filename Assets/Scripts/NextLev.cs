using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NextLev : MonoBehaviour {

    public string Name;

    void OnMouseDown()
    {        
        Application.LoadLevel(Name);
    }
}

