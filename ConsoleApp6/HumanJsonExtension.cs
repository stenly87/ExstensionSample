// методы расширения
// Extension
// Можно создавать методы, которые смогут выполняться над
// объектами классов, которыми мы не управляем (не можем изменить)

// например, допустим, что класс Human объявлен в отдельной
// библиотеке и недоступен нам для изменения
// но мы хотим добавить метод, который можно вызвать на объекте
// класса Human
//метод расширения создается в публичном статичном классе с любым именем
//сам метод тоже объявляется как публичный и статичный
//первый аргумент метода включает в себя слово this и тип класса
//для которого создается расширение
using System.Text.Json;
using System.Xml.Serialization;

namespace Test
{
    public static class HumanJsonExtension
    {
        public static string GetJson(this Human human)
        {
            return JsonSerializer.Serialize(human);
        }

        public static string GetXml(this Human human)
        {
            string result = null;
            XmlSerializer xml = new XmlSerializer(typeof(Human));
            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms))
            {
                xml.Serialize(ms, human);
                ms.Position = 0;
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}