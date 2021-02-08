# Parking System.

## Introduction
This system will contain a `Ticket` system, where a customer will be receiving a ticket depending on the `Vehicle` type they're arriving in. Once the customer `Checks in` their vehicle, it will be printed on the Ticket when they're arrived; Date and Time. 

Once they decide to `Check out` of the Parking Lot, they'll be charged with a `Price` per hour, decided by the `Vehicle` type they arrived in.

#### The program contains following Classes:
> 1. `Vehicle` types Classes w/ `GetPrice()`: Inheritance down to - `Car`, `Truck`, `Trailer` & `Disabled` Parking Lots.
> 2. `Ticket` Class w/ `Ticket()` & `GetNextID()`.
> 3. `Parking System` Class w/ `CheckIn()`, `CheckOut()` & `FreeLotsAvailable()`.
> 4. `SystemMenu` Class w/ `Menu()`, `CheckInMenu()`, `CheckAvailableLots()` & `CheckOutMenu()`.
> 5. `Program` Class.

#### Input:
The customer will be walking over to the Parking System, where they'll be having to choose between **3 options** on the screen. If they'd like to `Check in`, see the `Available lots` for the vehicle they're in or if they'd like to `Check out` their vehicle.

After that, it'll take them to the belonging `Sub Menus`, which displays a list of vehicles there can park there. The customer have to type in what vehicle they'll like to check on.

#### Output:
The first screen appear with listed options.
> 1. **Menu:**
> - Would you like to Check In? 
> - Check on the Available Lots? 
> - Would you like to Check Out?

Sub Menus will each appear depending on what the Customer will be choosing above.

> 1. **Would you like to Check In?**
  > 2. What type of Vehicle would you be checking in?
> - Regular Car.
> - Car with a Trailer.
> - Truck or Bus.
> - Disabled parking.

> 1. **Check on the Available Lot?**
  > 2. Choose the specific type of Vehicle you'd like to check on:
> - Regular Car.
> - Car with a Trailer.
> - Truck or Bus.
> - Disabled parking.

> 1. **Would you like to Check Out?**
  > 2. Enter your Ticket number:
> - `Customer will be having to input their Ticket ID Number here.`

