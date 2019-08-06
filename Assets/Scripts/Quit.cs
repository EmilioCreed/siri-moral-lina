using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{

    public void ApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
