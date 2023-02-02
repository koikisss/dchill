using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Вы вышли из игры");
        Application.Quit();
    }
}
