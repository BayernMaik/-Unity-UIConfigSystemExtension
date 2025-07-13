using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/Tag/String",
        order = 0
    )]
    public class ConfigTagTitle : ConfigTag<string> {}
}