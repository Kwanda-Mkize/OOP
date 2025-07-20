using System;
using System.Threading;

//Understaing the base class
// new B();

//Vehicle Example----------------------------
// Car car = new Car("Audi", "12");
// car.Display();

// Motorcycle motorcycle = new Motorcycle("Yamaha", "5");
// motorcycle.Display();


//Banking Example------------------------------
// SavingsAccount savings = new SavingsAccount(1000);
// savings.CalculateInterest();
// savings.ShowInterest();


//API Versioning Example
PaymentController controller = new PaymentController();
controller.PaymentHandler("v1");