using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
public void CloseApp()
{
    UnityEngine.Debug.LogError("Close App");
    Application.Quit();
}

}