using MyDietDishes.Repositores;
using MyDietDishes.Entities;
using MyDietDishes.Data;

var dishRepository = new SqlRepository<Meal>(new MotoAppDbContext());
AddEmployees(dishRepository);
WriteAllConsole(dishRepository);

static void AddEmployees(IRepository<Meal> employeeRepository)
{
    employeeRepository.Add(new Meal { MealName = "Jajecznica z cebulką i suszonymi pomidorami podana z pieczywem i sałatką z papryki i ogórka" });
    employeeRepository.Add(new Meal { MealName = "Pieczone trybowane udko z kurczaka w sosie meksykańskim z ryżem brązowym" });
    employeeRepository.Add(new Meal { MealName = "Wegańskie pulpecki na puree z batata i pietruszki oraz warzywa na parze" });
    employeeRepository.Save();
}

static void WriteAllConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}