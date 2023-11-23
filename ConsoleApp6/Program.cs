// методы расширения
// Extension
// Можно создавать методы, которые смогут выполняться над
// объектами классов, которыми мы не управляем (не можем изменить)

// например, допустим, что класс Human объявлен в отдельной
// библиотеке и недоступен нам для изменения
// но мы хотим добавить метод, который можно вызвать на объекте
// класса Human
using Test;
Human human = new Human { LastName = "Петров", FirstName = "Сергей", PatronymicName = "Венеаминович" };
Console.WriteLine(human.GetFio());
Console.WriteLine(human.GetJson());
Console.WriteLine(human.GetXml());
