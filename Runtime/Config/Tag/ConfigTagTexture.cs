using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/Tag/Texture",
        order = 0
    )]
    public class ConfigTagTexture : ConfigTag<Texture> {}
}