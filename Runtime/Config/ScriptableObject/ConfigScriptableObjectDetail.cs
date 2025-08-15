using UnityEngine;

namespace UI
{
    [CreateAssetMenu(
        fileName = "UI Config",
        menuName = "UI Config/ScriptableObject/Detail",
        order = 0
    )]
    public class ConfigScriptableObjectDetail : ConfigScriptableObject<Detail> {}
}