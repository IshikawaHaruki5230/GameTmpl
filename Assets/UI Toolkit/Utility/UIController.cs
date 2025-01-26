using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject sampleButton;
    private UIDocument _uiDocument;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var button = Instantiate(sampleButton);
        _uiDocument = button.GetComponent<UIDocument>();
        var buttonElement = _uiDocument.rootVisualElement.Q<Button>("Button1");
        buttonElement.clicked += () => 
        {
            var label = _uiDocument.rootVisualElement.Q<Label>("Label1");
            label.text = "clickd!";
            var baseElement = _uiDocument.rootVisualElement.Q<VisualElement>("Base");
            baseElement.style.width = 150;
            baseElement.style.height = 150;
            baseElement.transform.position = GetRandomScreenPosition();
        };

    }

    private Vector3 GetRandomScreenPosition()
    {
        return new Vector3(Random.Range(0,1000), Random.Range(0, 1000), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
