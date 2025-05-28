using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void Setup()
    {
        _person = new Person();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] input = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };

        List<Person> expected = new List<Person>()
        {
            new Person
            {
                Name = "Alice",
                Age = 35,
                Id = "A001"
            },

        new Person
        {
            Name = "Bob",
            Age = 30,
            Id = "B002"
        }
            
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(input);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expected[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expected[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expected[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        //Arrange
        List<Person> input = new List<Person>()
        {
            new Person
            {
                Name = "Alice",
                Age = 35,
                Id = "A001"
            },

        new Person
        {
            Name = "Bob",
            Age = 30,
            Id = "B002"
        }

        };

        string expected = "Bob with ID: B002 is 30 years old." +
                           Environment.NewLine +
                           "Alice with ID: A001 is 35 years old.";

        // Act 
        string actual = this._person.GetByAgeAscending(input);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));



    }
}
