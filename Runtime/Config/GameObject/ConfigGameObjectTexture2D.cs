using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/GameObject/Texture2D",
        order = 0
    )]
    public class ConfigGameObjectTexture2D : ConfigGameObject<Texture2D> {}
}