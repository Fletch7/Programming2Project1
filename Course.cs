using System;
using System.ComponentModel;

public class Course(string code, string name, string description, int credits, double fees, Department department)
{
	public string Code { get; } = code;
	public string Name { get; } = name;
	public string Description { get; } = description;
	public int Credits { get; } = credits;
	public double Fees { get; } = fees;
	public Department department { get; } = department;

}
