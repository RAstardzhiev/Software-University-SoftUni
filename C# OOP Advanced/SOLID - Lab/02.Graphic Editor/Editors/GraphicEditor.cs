namespace _02.Graphic_Editor.Editors
{
    using System;
    using Interfaces;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape) => Console.WriteLine(shape.Draw());
    }
}