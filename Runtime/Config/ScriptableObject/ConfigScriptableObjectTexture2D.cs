using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/ScriptableObject/Texture2D",
        order = 0
    )]
    public class ConfigScriptableObjectTexture2D : ConfigScriptableObject<Texture2D> {}
}