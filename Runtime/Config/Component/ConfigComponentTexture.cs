using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/Component/Texture",
        order = 0
    )]
    public class ConfigComponentTexture : ConfigComponent<Texture> {}
}