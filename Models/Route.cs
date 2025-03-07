namespace NoPopsUI.Maui.Models
{
    public class Route<T>
    {
        public string? Path { get; set; }
        public T? Component { get; set; }
    }
}