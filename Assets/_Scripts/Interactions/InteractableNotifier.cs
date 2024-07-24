using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableNotifier : MonoBehaviour
{
    public void ShowNotifier()
    {
        Debug.Log("Notif Begin");
    }    

    public void HideNotifier()
    {
        Debug.Log("Notif End!");
    }
}
