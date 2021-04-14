using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    public void QuitApplication()
    {
        //Debug.Log("COMMAND TO QUIT APPLICATION!!!!");
        Application.Quit();
    }
}
