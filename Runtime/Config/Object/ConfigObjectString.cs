using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/Object/String",
        order = 0
    )]
    public class ConfigObjectString : ConfigObject<string> {}
}