using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class pickupAxe : MonoBehaviour, IPointerClickHandler
{
    public GameObject go;

    public void OnPointerClick(PointerEventData eventData)
    {

        Debug.Log("Clicked!");
        Destroy(go);

    }

   
}

