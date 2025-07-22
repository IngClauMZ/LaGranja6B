using UnityEngine;
using UnityEngine.UIElements;

public class InventrioControlUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;

    void OnEnable(){
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }

    void Update()
    {
        if(GameManager.instancia.huevo != huevosPrevios){
            huevosPrevios = GameManager.instancia.huevo;
            labelHuevos.text = $"Huevos: {huevosPrevios}";
        }
    }
}
