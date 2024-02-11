using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "PlayerData/Stats", order = 1)]
public class PlayerData : ScriptableObject
{
    public string type;
    public string objName;
    public float speed;
}
