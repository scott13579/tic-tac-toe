using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class PanelController : MonoBehaviour
{
    public bool IsShow { get; private set; }
    
    private RectTransform _rectTransform;
    private Vector2 _hideAnchoredPosition;
    
    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _hideAnchoredPosition = _rectTransform.anchoredPosition;
        IsShow = false;
    }

    public void Show()
    {
        _rectTransform.anchoredPosition = Vector2.one;
        IsShow = true;
    }
    
}
