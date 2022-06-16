using UnityEditor;

namespace Maze
{
    public class MenuItems
    {
        [MenuItem("Maze/Пункт меню №0 ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Geekbrains");
        }

    }
}
