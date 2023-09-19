using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchDragObject2 : MonoBehaviour, IPointerDownHandler, IDragHandler {
    private bool isDragging = false;
    private Vector2 offset;

    public void OnPointerDown(PointerEventData eventData) {
        isDragging = true;
        offset = transform.position - (Vector3)eventData.position;
    }

    public void OnDrag(PointerEventData eventData) {
        if (isDragging) {
            Debug.Log("Test................");
            Vector3 newPosition = (Vector3)eventData.position + new Vector3(offset.x, offset.y, 0.0f);
            newPosition.z = 0.0f;
            transform.position = newPosition;
        }
    }


}
