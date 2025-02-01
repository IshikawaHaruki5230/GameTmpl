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
            // UI�h�L�������g���擾
            var root = uiDocument.rootVisualElement;

            // �{�^�����擾
            button = root.Q<Button>("extendsButton");
            button.clicked += () => Debug.Log("Button clicked!");
        }
    }
}
