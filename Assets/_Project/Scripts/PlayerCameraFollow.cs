using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
  public Transform targetPlayer;


    public Vector3 originalPos = new Vector3(0, 4.27f, -7);

    public Vector3 originalRot = new Vector3(17.01f, 0, 0);

 
    public Vector3 dis = new Vector3(0, 4.81f, -7.59f);


    public float smooth = 5f;

    private Transform m_cameraTransform;
    private float m_deltaTime;

    void Awake()
    {
        m_cameraTransform = transform;
    }

    void Update()
    {
        m_deltaTime = Time.deltaTime;
        if (null == targetPlayer)
        {
            m_cameraTransform.position = Vector3.Lerp(m_cameraTransform.position, originalPos, m_deltaTime * smooth);
            m_cameraTransform.eulerAngles = Vector3.Lerp(m_cameraTransform.eulerAngles, originalRot, m_deltaTime * smooth);
        }
        else
        {

            m_cameraTransform.position = Vector3.Slerp(m_cameraTransform.position, dis + targetPlayer.position, smooth * m_deltaTime);

            m_cameraTransform.LookAt(m_cameraTransform.position, Vector3.up);
        }
    }
}
