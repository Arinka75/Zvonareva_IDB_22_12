using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    private Renderer cubeRenderer;  // ������ �� ��������� Renderer ���� 

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();  // �������� ��������� Renderer ���� 
        cubeRenderer.material.color = Color.red;  // ������������� ���� ���� �� ������� 
    }
}
