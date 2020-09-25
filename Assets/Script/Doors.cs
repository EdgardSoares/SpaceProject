using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{

    public float _speed;
    Animator _anim;
    public bool _isOpen = false;
    public GameObject _PressE;
    public Vector3 _pos;



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "player")
        {
            _isOpen = true;
            _PressE.SetActive(true);
            transform.position += Vector3.up * _speed * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "player")
        {
            _PressE.SetActive(false);
            _anim.SetBool("isOpen", false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
       if(_isOpen == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                
            }
        }
    }

}
