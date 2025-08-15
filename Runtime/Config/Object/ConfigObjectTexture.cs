using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/Object/Texture",
        order = 0
    )]
    public class ConfigObjectTexture : ConfigObject<Texture> {}
}