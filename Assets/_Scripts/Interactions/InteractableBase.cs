using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class InteractableBase : MonoBehaviour, IInteractable
{
    InteractableNotifier notifier;

    public UnityEvent OnEnterRange { get; private set; } = new();
    public UnityEvent OnBeginInteract { get; private set; } = new();
    public UnityEvent OnEndInteract { get; private set; } = new();
    public UnityEvent OnExitRange { get; private set; } = new();

    private void Awake()
    {
        notifier = GetComponent<InteractableNotifier>();
        OnEnterRange.AddListener(notifier.ShowNotifier);
        OnEndInteract.AddListener(notifier.HideNotifier);
        OnExitRange.AddListener(notifier.HideNotifier);
    }

    public virtual void Interact()
    {
        OnBeginInteract.Invoke();
    }

    // TODO: visually indicate when item is in interact range

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnEnterRange.Invoke();
            collision.GetComponent<PlayerController>().Interactor.SetFocusedInteractable(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnExitRange.Invoke();
            collision.GetComponent<PlayerController>().Interactor.SetFocusedInteractable(null);
        }
    }
}
