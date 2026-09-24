using MyLib;
namespace Bai2_2;

using System.Collections;

public class PersonList
{
    private readonly ArrayList persons;

    public PersonList()
    {
        this.persons = new ArrayList();
    }

    public PersonList(PersonList list)
    {
        this.persons = new ArrayList();
        foreach (Person person in list.persons)
        {
            this.persons.Add(new Person(person));
        }
    }

    public void Input()
    {
        Console.Write("Nhap so luong nguoi: ");
        int count;
        while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
        {
            Console.Write("So luong khong hop le. Nhap lai: ");
        }
        Console.WriteLine($"Da nhap so luong nguoi: {count}");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Nhap thong tin nguoi thu {i + 1}:");
            Person person = new Person();
            person.Input();
            this.Add(person);
        }
    }

    public void Output()
    {
        foreach (Person person in this.persons)
        {
            person.Output();
        }
    }

    public void Add(Person x)
    {
        this.persons.Add(x);
    }

    public PersonList LivingPeople()
    {
        PersonList list = new PersonList();
        foreach (Person person in this.persons)
        {
            if (person.IsLiving())
            {
                list.Add(new Person(person));
            }
        }

        return list;
    }
}