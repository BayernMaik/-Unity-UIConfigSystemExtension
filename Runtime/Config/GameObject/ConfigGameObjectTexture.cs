using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/GameObject/Texture",
        order = 0
    )]
    public class ConfigGameObjectTexture : ConfigGameObject<Texture> {}
}