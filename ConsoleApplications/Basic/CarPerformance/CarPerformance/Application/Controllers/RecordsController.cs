using System;
using CarPerformance.Entities;
using CarPerformance.Services;

namespace CarPerformance.Application.Controllers
{
    public class RecordsController
    {
        private readonly RecordsService _service;
        
        public RecordsController()
        {
            this._service = new RecordsService();
            
            ShowOptions();
            int option = GetOptionSelected();
            
        }
        private void ShowOptions()
        {
            Console.WriteLine("\n *** Opções disponíveis *** \n ");
            Console.WriteLine("Digite 1 - Cadastrar um carro");
            Console.WriteLine("Digite 2 - Consultar um carro");
        }

        private int GetOptionSelected()
        {
            string option = Console.ReadLine();
            int optionNumber = Convert.ToInt32(option);

            return optionNumber;
        }

        private void SetApplicationFlow(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Digite o id do carro cadastrado \n");
                int carId = Convert.ToInt32(Console.ReadLine());
                Car car = _service.GetCarById(carId);
                
                Console.WriteLine("**************************************");
                Console.WriteLine(car.CarModel);
                Console.WriteLine(car.CarManufacture);
                Console.WriteLine(car.Year.ToString());
            }
            else if (option == 2)
            {
                Car car = new Car();
                
                Console.WriteLine("Digite os dados requisitados \n");
                
                Console.WriteLine("Modelo");
                car.CarModel = Console.ReadLine();
                
                Console.WriteLine("Fabricante");
                car.CarManufacture = Console.ReadLine();
                
                Console.WriteLine("Ano");
                car.Year = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                car.CarId = random.Next();

                try
                {
                    _service.InsertNewCar(car);
                    Console.WriteLine("Carro cadastrado com sucesso :)");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Falha ao cadastrar o carro :(");
                    Console.WriteLine(e.Message);
                    
                }
            }
        }
    }
}