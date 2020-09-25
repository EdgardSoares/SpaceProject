using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCreditos : MonoBehaviour
{
    public GameObject _credito, _canvas, _pressAnyKey;

    public void OnMouseDown()
    {
        _credito.SetActive(true);
        _canvas.SetActive(false);
        _pressAnyKey.SetActive(true);
    }


    public void Update()
    {
        if (Input.anyKeyDown)
        {
            _credito.SetActive(false);
            _canvas.SetActive(true);
            _pressAnyKey.SetActive(false);
        }
    }
}
