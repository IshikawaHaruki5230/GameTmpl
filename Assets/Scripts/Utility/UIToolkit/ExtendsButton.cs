using UnityEngine;
using UnityEngine.UIElements;

namespace Utility.UIToolkit
{
    [RequireComponent(typeof(UIDocument))]
    public class ExtendsButton : MonoBehaviour
    {
        [SerializeField]
        private UIDocument uiDocument;

        private Button button;

        void OnEnable()
        {
            // UIドキュメントを取得
            var root = uiDocument.rootVisualElement;

            // ボタンを取得
            button = root.Q<Button>("extendsButton");
            button.clicked += () => Debug.Log("Button clicked!");
        }
    }
}
