using System;
using UnityEngine;

public class SoakServerBehaviour : MonoBehaviour
{
    private SoakServer m_Server;

    void Start()
    {
        m_Server = new SoakServer();
        m_Server.Start();
    }

    void OnDestroy()
    {
        m_Server.Dispose();
    }

    [Obsolete]
    void FixedUpdate()
    {
        m_Server.Update();
    }
}
