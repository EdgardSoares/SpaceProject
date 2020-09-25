using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class Menu : MonoBehaviour
{
  
    public CinemachineVirtualCamera _currentCamera;
    // Start is called before the first frame update
    void Start()
    {
        _currentCamera.Priority++;
    
    }

    // Update is called once per frame
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
        _currentCamera.Priority --;
        _currentCamera = target;
        _currentCamera.Priority++;
    }

}
