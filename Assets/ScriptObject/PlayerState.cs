using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "PlayerData/State", order = 1)]
public class PlayerState : ScriptableObject
{
    public enum State
    {
        Waling,
        Sleeping,
        Running,
        Sitting
    }

    public State state = State.Waling;
}
