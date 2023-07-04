using MessagePack;
using System.Text.Json;

var person = new Person(123, "test", 123);

var data = MessagePackSerializer.Serialize<Person>(person);

for (int i = 0; i < data.Length; i++)
{
    Console.Write($"{data[i]:X} ");
}

var initData = MessagePackSerializer.Deserialize<Person>(data);

var json = JsonSerializer.Serialize<Person>(person);

Console.WriteLine(initData.ToString());


[MessagePackObject(false)]
public class Person
{
    [Key(1)]
    public int Id { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public int Age { get; set; }


    public Person(int id, string name, int age)
    {
        Id = id;
        Name= name;
        Age= age;
    }

}