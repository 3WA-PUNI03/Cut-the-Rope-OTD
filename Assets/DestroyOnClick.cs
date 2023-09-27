using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class DestroyOnClick : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] InputActionReference _mouse;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("over");
        //if(_mouse.action.IsPressed())
        {
            Destroy(gameObject);
        }
    }

}
