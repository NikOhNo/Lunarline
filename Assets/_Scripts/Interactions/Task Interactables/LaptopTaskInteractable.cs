using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LaptopTaskInteractable : InteractableBase
{
    readonly LaptopTask laptopTask = new();

    public override void Interact()
    {
        base.Interact();

        Debug.Log("Yahoo!");
        laptopTask.BeginTask();
    }
}
