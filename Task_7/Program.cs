// See https://aka.ms/new-console-template for more information


using Task_7;

Car car1 = new Car();

Car car2 = new Car(20);
car2.DoorCount = 20;
car2.BrandCar = "Mazda";

Car car3 = new Car(10, "Priora");
car3.DoorCount = 2;
car3.BrandCar = "Vaz";




Print.PrintCar(car1);
Print.PrintCar(car2);
Print.PrintCar(car3);