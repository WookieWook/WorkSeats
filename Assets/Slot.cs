﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {
    
    public GameObject item {
        get {
            if (transform.childCount > 0) {
                return transform.GetChild (0).gameObject;
            }
            return null;
        }

    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item) {
            DragHandler.itemBeingDrag.transform.SetParent(transform);

        }
    }

}
