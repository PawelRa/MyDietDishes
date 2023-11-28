namespace MyDietDishes.Entities
{
    public class Meal : EnityBase
    {
        public Meal() { }

        public Meal(string name, string time, int rating) { }

        public string? MealName { get; set; }

        public string? Time { get; set; }

        public int? Rating { get; set; }

        public override string ToString() => $"Id: {Id}, Posiłek: {MealName}, Pora: {Time}, Ocena: {Rating}";
    }
}
