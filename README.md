# DynamicTypes
DynamicBag is a toy project that uses a Dictionary&lt;string, dynamic> to create a dynamic storage class. 

I'm just playing with Dynamic and Polymorphism...

```csharp
DynamicBag shoppingBag = new DynamicBag();
DynamicBag spareBag = new DynamicBag();

//Add some stuff to our bags (and add the spareBag into the shoppingBag)
shoppingBag.Add("spareBag", spareBag);
shoppingBag.Add("shoppingList", new string[] { "eggs", "milk", "cheese" });

spareBag.Add("carCoin", "50ct");
spareBag.Add("carValue", 50);

//Save shoppingBag (with the spareBag inside) to file
shoppingBag.ToBinaryFile("shoppingBag.bin");

//Load shoppingBag (with the spareBag inside) from file
DynamicBag shoppingBag2 = DynamicBag.FromBinaryFile("shoppingBag.bin");

//Get some stuff from our bags (and get the spareBag out of the shoppingBag)
DynamicBag spareBag2 = shoppingBag2["spareBag"];
string carCoin2 = spareBag2["carCoin"];
int carValue2 = spareBag2["carValue"];
```
