using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Task
{
    public UnityEvent OnBeginTask { get; private set; } = new();
    public UnityEvent OnCompleteTask { get; private set; } = new();

    public virtual void BeginTask()
    {
        OnBeginTask.Invoke();
    }

    public virtual void CompleteTask()
    {
        OnCompleteTask.Invoke();
    }
}
