using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/GameObject/String",
        order = 0
    )]
    public class ConfigGameObjectString : ConfigGameObject<string> {}
}