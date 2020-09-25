using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource _clickSound;
     private float _FinishTime = 5f;
    private float _counter = 0f;

    public GameObject _pressAnyKey;
    public GameObject _Canvas;
    public GameObject _Creditos;
    public GameObject _back;

    public GameObject _camera;

    Menu _menu;
    // Start is called before the first frame update
    void Start()
    {
        _clickSound = GetComponent<AudioSource>();
        _menu = GetComponent<Menu>();
        
    }

    // Update is called once per frame
    public void Update()
    {
        _counter += Time.deltaTime;
        if(_counter > _FinishTime)
        {
            _pressAnyKey.SetActive(true);
            if (Input.anyKeyDown)
            {
                GameObject.Destroy(_pressAnyKey);
               // GameObject.Destroy(_pressAnyKey);
                _Canvas.SetActive(true);
                _back.SetActive(true);
               
            }
          
        }
        
    }


    public void OnMouseDown()
    {
        _clickSound.Play();        
        
    }

}


