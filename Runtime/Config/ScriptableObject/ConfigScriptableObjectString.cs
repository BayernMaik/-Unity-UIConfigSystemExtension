using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/ScriptableObject/String",
        order = 0
    )]
    public class ConfigScriptableObjectString : ConfigScriptableObject<string> {}
}