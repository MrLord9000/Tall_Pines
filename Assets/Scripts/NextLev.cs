using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class NextLev : MonoBehaviour {

    public string Name;

    void OnMouseDown()
    {
        //Application.UnloadLevel(Application.loadedLevelName);
        Application.LoadLevel(Name);
        
        //Application.LoadLevel()
    }
}

/*
public class NextLev : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        Debug.Log("dziala");
    }
}
*/