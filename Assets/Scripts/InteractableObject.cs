using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{

    public GameObject Object;
    public Text ObjectText;
    public string TextValue;
    public UnityEvent clicked;


    private void OnMouseDown()
    {

        ObjectText.text = this.Object.name;
        //Object.SetActive(false);

        clicked.Invoke();
    }


}