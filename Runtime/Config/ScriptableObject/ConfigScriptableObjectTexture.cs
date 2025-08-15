using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/ScriptableObject/Texture",
        order = 0
    )]
    public class ConfigScriptableObjectTexture : ConfigScriptableObject<Texture> {}
}