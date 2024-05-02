using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject Hoverpanel;


    public void OnPointerEnter(PointerEventData eventData)
    {
        Hoverpanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Hoverpanel.SetActive(false);

    }
}
