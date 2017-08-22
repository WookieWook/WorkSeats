using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FirstSeen : MonoBehaviour {

    public RectTransform panelRectTransform;

	// Use this for initialization
	void Start () {
        panelRectTransform.SetAsLastSibling();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
