using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow
{
    
    public Color myColor;         // �������� �����
    public MeshRenderer GO;      // ������ �� ������ �������
    public Material nevMat;
    private Transform mainCam;

    [MenuItem("�����������/ ����/ ��������� ��������")]

    public static void ShowMyWindow()
    {
        GetWindow(typeof(Window), false, "��������� ��������");
    }

    void OnGUI()
    {
        GO = EditorGUILayout.ObjectField("��� �������", GO, typeof(MeshRenderer), true) as MeshRenderer;
        nevMat = EditorGUILayout.ObjectField("�������� �������", GO, typeof(Material), true) as Material;

        if (GO)
        {
            myColor = RGBSlider(new Rect(10, 30, 200, 20), myColor);  // ��������� ����������������� ������ ��������� ��� ��������� ��������� �����
            GO.material.color = myColor; // �������� �������
        }
        else
        {
            if(GUI.Button(new Rect(0, 100, 100, 50), "�������"))
            {
                mainCam = Camera.main.transform;

                GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                MeshRenderer GORend = temp.GetComponent<MeshRenderer>();
                GORend.sharedMaterial = nevMat;
                temp.transform.position = new Vector3(mainCam.position.x, mainCam.position.y, mainCam.position.z + 10);

                GO = GORend;
            }

        }
        if(GUI.Button(new Rect(0, 200, 100, 50), "�������"))
        {
            DestroyImmediate(GO.gameObject);
            GO = null;
        }
    }

    // ��������� ����������������� ��������
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText) // �� �������� MinValue
    {

        // ������ ������������� � ������������ � ������������ � ������� ������� � ������� 
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);

        GUI.Label(labelRect, labelText);   // ������ Label �� ������

        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height); // ����� ������� ��������
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderMaxValue); // ������������ ������� � ��������� ��� ��������
        return sliderValue; // ���������� �������� ��������
    }

    // ��������� ������� ������� ������, ������ ������� �������� �� ���� ����
    Color RGBSlider(Rect screenRect, Color rgb)
    {
        screenRect.y += 10;
        // ��������� ���������������� �������, ������ ���
        rgb.r = LabelSlider(screenRect, rgb.r, 1.0f, "Red");

        // ������ ����������
        screenRect.y += 20;
        rgb.g = LabelSlider(screenRect, rgb.g, 1.0f, "Green");

        screenRect.y += 20;
        rgb.b = LabelSlider(screenRect, rgb.b, 1.0f, "Blue");

        screenRect.y += 20;
        rgb.a = LabelSlider(screenRect, rgb.a, 1.0f, "alpha");


        return rgb; // ���������� ����
    }
}
