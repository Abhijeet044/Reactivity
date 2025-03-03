using System;

namespace Domain;

public class Activity
{
public Guid Id { get; set; } = Guid.NewGuid();
public required string Title { get; set; }
public DateTime Date { get; set; }
public required string Description { get; set; }
public required string Category { get; set; }
public bool IsCancelled { get; set; }

//location properties
public required string City { get; set; }
public required string Venue { get; set; }
public double Latitude { get; set; }
public double Longitude { get; set; }
}
