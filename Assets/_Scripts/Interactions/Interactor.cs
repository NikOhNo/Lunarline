using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    private IInteractable focusedInteractable = null;

    public void SetFocusedInteractable(IInteractable interactable)
    {
        focusedInteractable = interactable;
    }

    public void BeginInteraction()
    {
        focusedInteractable?.Interact();
    }
}
