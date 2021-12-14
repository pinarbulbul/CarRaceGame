using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaScripts : MonoBehaviour
{
    public WheelCollider OnSolTekerlek, OnSagTekerlek, ArkaSolTekerlek, ArkaSagTekerlek;

    public float motorHizi;
    public float donmeHizi;

    // Update is called once per frame
    void Update()
    {
        ArkaSolTekerlek.motorTorque = motorHizi * Input.GetAxis("Vertical");
        ArkaSagTekerlek.motorTorque = motorHizi * Input.GetAxis("Vertical");
        OnSolTekerlek.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
        OnSagTekerlek.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
    }
}
