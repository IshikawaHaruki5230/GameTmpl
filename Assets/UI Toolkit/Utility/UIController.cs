using System.Linq;
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

        ListView listVIewElemnt = _uiDocument.rootVisualElement.Q<ListView>();
        listVIewElemnt.makeItem = () => new Label();
        listVIewElemnt.bindItem = (item, i) => { ((Label)item).text = $"{i}th element"; };
        listVIewElemnt.itemsSource = Enumerable.Range(0,5).ToList();
        listVIewElemnt.fixedItemHeight = 50;

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
