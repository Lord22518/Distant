var hello = () => Console.WriteLine("METANIT.COM");

var message = () => Console.Write("Hello ");
message += () => Console.WriteLine("World"); // добавляем анонимное лямбда-выражение
message += hello;   
message += Print;   

message.Invoke();
Console.WriteLine("--------------");

message -= Print;  
message -= hello;   
message?.Invoke();  

void Print() => Console.WriteLine("Welcome to C#");