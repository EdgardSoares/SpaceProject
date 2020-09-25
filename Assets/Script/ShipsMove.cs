using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ShipsMove : MonoBehaviour
{
    public float _speed;
    public float _anguloX, _anguloY, _anguloZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Time.deltaTime * _anguloX, _anguloY, _anguloZ - _speed));
    }
}
