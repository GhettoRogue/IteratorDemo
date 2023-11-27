using IteratorDemo;

var person = new Person()
{
    Id = 0,
    Name = "Vladimir",
    DateTime = DateTime.Now
};

var properties = new PropertyIterator(person);

foreach (var prop in properties)
{
    Console.WriteLine($"{prop.name} [{prop.type.Name} {prop.value}]" );
}