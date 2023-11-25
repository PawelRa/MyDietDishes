namespace MyDietDishes.Entities
{
    public class Meal : EnityBase
    {
        public Meal() { }

        public Meal(string name) { }

        public string? MealName { get; set; }

        public override string ToString() => $"Id: {Id}, Posiłek: {MealName}";
    }
}
