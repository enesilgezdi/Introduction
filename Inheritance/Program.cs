using Inheritance.Models;


Car car = new Car()
{
    Id = 1,
    Color = "red",
    CreatedDate = "23-09-2024",
    FuelType = "Benzin",
    Mil = 12123,
    NumberOfDoor = 4,
    TransmissionType = "Otamatik",
    UpdatedDate = null,

};


// Bunları absract yaptımız için new dondurmuyor
//Vehicle vehicle = new Vehicle();
//MotorVehicle motorVehicle = new MotorVehicle();

Console.WriteLine(car);

