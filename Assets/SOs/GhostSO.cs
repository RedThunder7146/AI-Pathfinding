using UnityEngine;

[CreateAssetMenu(fileName = "GhostSO", menuName = "Scriptable Objects/GhostSO")]
public class GhostSO : ScriptableObject
{
    public string name;
    public int cooldown;
    public float retreatXPos;
    public float retreatYPos;
    public float retreatZPos;
}
