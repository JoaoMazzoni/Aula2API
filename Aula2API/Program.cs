using Controllers;
using ModelsClassLibrary;


Console.WriteLine("Inicio do Processamento");

Car car = new Car()
{
    Id = 1,
    Name = "Carro Muito Legal",
    Color = "Vermelho",
    Year = 2025
};

//for(int i = 0; i < 10000; i++)
//{
//    car.Name = "Teste - " + i.ToString();   
//    Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido - " + car.Name : "Erro ao Inserir Registro"); 
//}

foreach(var item in new CarController().GetAll().Where(x => x.Id > 990).ToList().Take(10))
{
    Console.WriteLine(item);
}

//Console.WriteLine(car);

//Console.WriteLine("EXEMPLO INSERT");
//Console.WriteLine(new CarController().Insert(car) ? "\nRegistro Inserido" : "\nErro ao Inserir Registro");

//Console.WriteLine("EXEMPLO UPDATE");
//Console.WriteLine(new CarController().Update(car) ? "\nRegistro Atualizado" : "\nErro ao Atualizar Registro");

//Console.WriteLine("EXEMPLO DELETE");
//Console.WriteLine(new CarController().Delete(1) ? "\nRegistro Deletado" : "\nErro ao Deletar Registro");

//Console.WriteLine(" EXEMPLO GETALL - VALIDAÇÃO");
//foreach (var item in new CarController().GetAll())
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("EXEMPLO GET");
//Console.WriteLine(new CarController().Get(1));