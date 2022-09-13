using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtAxisController : MonoBehaviour
{    
    [Header("Set the target to Look At")]
    public GameObject target;

    [Header("Conditions")]
    public bool XAxis;
    public bool YAxis;
    public bool ZAxis;
    public bool AllAxis;

    void Update()
    {
        if(XAxis)
        {
            Vector3 targetPositionX = new Vector3(transform.position.x, target.transform.position.y, target.transform.position.z);
            transform.LookAt(targetPositionX);
        }  
        if(YAxis)
        {
            Vector3 targetPositionY = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.LookAt(targetPositionY);
        }
        if(ZAxis)
        {
            Vector3 targetPositionZ = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
            transform.LookAt(targetPositionZ);
        }
        if(AllAxis)
        {
            Vector3 targetPositionAllAxis = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
            transform.LookAt(targetPositionAllAxis);
        }            
    }
}
