using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstacaoRotation : MonoBehaviour
{
    public float _speed;
    public float _angX, _angY, _angZ;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * _angX, _angY, _angZ));
    }
}
