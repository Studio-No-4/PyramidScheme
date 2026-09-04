using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "RoleCards", menuName = "Scriptable Objects/RoleCards")]
public class RoleCards : ScriptableObject
{
    public string RoleName;
    public string RoleAbility;
    public Sprite RoleImageFront;
    public Sprite RoleImageBack;

}
