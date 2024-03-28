namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IShape shape = new Diamond();

            GraphicEditor editor = new GraphicEditor();

            editor.DrawShape(shape);
        }
    }
}
