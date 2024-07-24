using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IInteractable
{
    UnityEvent OnEnterRange { get; }
    UnityEvent OnBeginInteract { get; }
    void Interact();
    UnityEvent OnEndInteract { get; }
    UnityEvent OnExitRange { get; }
}
