# DynamicTypes
DynamicBag is a toy project that uses a Dictionary&lt;string, dynamic> to create a dynamic storage class. 

I'm just playing with Dynamic and Polymorphism...

```csharp
DynamicBag shoppingBag = new DynamicBag();
DynamicBag spareBag = new DynamicBag();

shoppingBag.Add("spareBag", spareBag);
shoppingBag.Add("shoppingList", new string[] { "eggs", "milk", "cheese" });

spareBag.Add("carCoin", "50ct");
spareBag.Add("carValue", 50);

shoppingBag.ToBinaryFile("shoppingBag.bin");

DynamicBag shoppingBag2 = DynamicBag.FromBinaryFile("shoppingBag.bin");
DynamicBag spareBag = shoppingBag2["spareBag"];

string carCoin2 = spareBag["carCoin"];
int carValue2 = spareBag["carValue"];
```
