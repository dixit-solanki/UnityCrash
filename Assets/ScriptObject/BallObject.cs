using UnityEngine;

[CreateAssetMenu(fileName="Toy", menuName= "ScriptableObject/ToyManager",order=1)]
public class BallObject : ScriptableObject
{
    public string objName;
    public string color;
    public float intensity;
    public float mass;
}
