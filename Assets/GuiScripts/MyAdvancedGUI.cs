using UnityEngine;


public class MyAdvancedGUI : MonoBehaviour
{
    [SerializeField] [Header("Отладочная переменная")][Range(0,100)]
    [Tooltip("Значение находится в диапазоне от 0 до 100")]
    private float mySlider = 1.0f; // Положение пользовательского слайдера
    [SerializeField][TextArea(5,10)]
    private string my2Slider;
    [SerializeField]
    private int my3Slider = 1;

    public Color myColor;         // Градиент цвета
    public MeshRenderer GO;      // Ссылка на рендер объекта

    void OnGUI()
    {
        mySlider = LabelSlider(new Rect(10, 10, 200, 20), mySlider, 5.0f, "My Slider", 0); // Отрисовка пользовательского слайдера
        myColor = RGBSlider(new Rect(10, 30, 200, 20), myColor);  // Отрисовка пользовательского набора слайдеров для получения градиента цвета
        GO.material.color = myColor; // Покраска объекта
    }

    // Отрисовка пользовательского слайдера
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText, float minValue) // ДЗ добавить MinValue
    {

        // создаём прямоугольник с координатами в пространстве и заданой шириной и высотой 
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);
               
        GUI.Label(labelRect, labelText);   // создаём Label на экране

        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height); // Задаём размеры слайдера
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, minValue, sliderMaxValue); // Вырисовываем слайдер и считываем его параметр
        return sliderValue; // Возвращаем значение слайдера
    }

    // Отрисовка тройной слайдер группы, каждый слайдер отвечает за свой цвет
    Color RGBSlider(Rect screenRect, Color rgb)
    {
        // Используя пользовательский слайдер, создаём его
        rgb.r = LabelSlider(screenRect, rgb.r, 1.0f, "Red", 0f);
        
        // делаем промежуток
        screenRect.y += 20;
        rgb.g = LabelSlider(screenRect, rgb.g, 1.0f, "Green", 0f);

        screenRect.y += 20;
        rgb.b = LabelSlider(screenRect, rgb.b, 1.0f, "Blue", 0f);

        screenRect.y += 20;
        rgb.a = LabelSlider(screenRect, rgb.a, 1.0f, "alpha", 0f);

        if (GUI.Button(new Rect(0, 110, 100, 50), "minValue"))
            rgb.a = LabelSlider(screenRect, 0f, 1.0f, "alpha", 0f);

        return rgb; // возвращаем цвет
    } 
}
