﻿namespace RcNulls;

internal class Person
{
    public string FirstName { get; }
    public Option<string> LastName { get; }

    private Person(string firstName, Option<string> lastName) =>
        (FirstName, LastName) = (firstName, lastName);

    public static Person Create(string firstName, string lastName) =>
        new(firstName, Option<string>.Some(lastName));

    public static Person Create(string name) => new(name, Option<string>.None());
}
