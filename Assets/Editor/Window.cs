using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow
{
    
    public Color myColor;         // Градиент цвета
    public MeshRenderer GO;      // Ссылка на рендер объекта
    public Material nevMat;
    private Transform mainCam;

    [MenuItem("Инструменты/ Окно/ Генератор объектов")]

    public static void ShowMyWindow()
    {
        GetWindow(typeof(Window), false, "Генератор объектов");
    }

    void OnGUI()
    {
        GO = EditorGUILayout.ObjectField("Меш объекта", GO, typeof(MeshRenderer), true) as MeshRenderer;
        nevMat = EditorGUILayout.ObjectField("Материал объекта", GO, typeof(Material), true) as Material;

        if (GO)
        {
            myColor = RGBSlider(new Rect(10, 30, 200, 20), myColor);  // Отрисовка пользовательского набора слайдеров для получения градиента цвета
            GO.material.color = myColor; // Покраска объекта
        }
        else
        {
            if(GUI.Button(new Rect(0, 100, 100, 50), "Создать"))
            {
                mainCam = Camera.main.transform;

                GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                MeshRenderer GORend = temp.GetComponent<MeshRenderer>();
                GORend.sharedMaterial = nevMat;
                temp.transform.position = new Vector3(mainCam.position.x, mainCam.position.y, mainCam.position.z + 10);

                GO = GORend;
            }

        }
        if(GUI.Button(new Rect(0, 200, 100, 50), "Удалить"))
        {
            DestroyImmediate(GO.gameObject);
            GO = null;
        }
    }

    // Отрисовка пользовательского слайдера
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText) // ДЗ добавить MinValue
    {

        // создаём прямоугольник с координатами в пространстве и заданой шириной и высотой 
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);

        GUI.Label(labelRect, labelText);   // создаём Label на экране

        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height); // Задаём размеры слайдера
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderMaxValue); // Вырисовываем слайдер и считываем его параметр
        return sliderValue; // Возвращаем значение слайдера
    }

    // Отрисовка тройной слайдер группы, каждый слайдер отвечает за свой цвет
    Color RGBSlider(Rect screenRect, Color rgb)
    {
        screenRect.y += 10;
        // Используя пользовательский слайдер, создаём его
        rgb.r = LabelSlider(screenRect, rgb.r, 1.0f, "Red");

        // делаем промежуток
        screenRect.y += 20;
        rgb.g = LabelSlider(screenRect, rgb.g, 1.0f, "Green");

        screenRect.y += 20;
        rgb.b = LabelSlider(screenRect, rgb.b, 1.0f, "Blue");

        screenRect.y += 20;
        rgb.a = LabelSlider(screenRect, rgb.a, 1.0f, "alpha");


        return rgb; // возвращаем цвет
    }
}
