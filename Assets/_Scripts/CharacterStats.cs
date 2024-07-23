using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStats : ScriptableObject
{
    [SerializeField] float moveSpeed = 7.5f;
    public float MoveSpeed => moveSpeed;
}
