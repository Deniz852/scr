using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActivate : MonoBehaviour
{

    public GameObject objectToEnable; // ������, ������� ����� ��������
    public GameObject object1; // ������ ������ ��� ��������
    public GameObject object2; // ������ ������ ��� ��������
    public GameObject object3; // ������ ������ ��� ��������

    void Update()
    {
        if (!object1.activeSelf && !object2.activeSelf && !object3.activeSelf)
        {
            objectToEnable.SetActive(true);
        }
    }
}
