namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }  //El signo de pregunta es por si el campo name viene vacio --> osea null. Para que sea string y null dependiendo del caso
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
}
