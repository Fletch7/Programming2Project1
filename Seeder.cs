using System;
using System.Collections.Generic;

public class Seeder
{
	public List<Institution> Institutions { get; } = new List<Institution>;
	public List<Department> Departments { get; } = new List<Departments>;
	public List<Course> Courses { get; } = new List<Courses>;

	public Seeder()
	{
		ListOfInstitutions();
		ListOfDepartments();
		ListOfCourses();
	}
	
	private void SeedInstitutions()
	{
		Institutions.Add(new Institution("Otago Polytech", "Otago", "New Zealand"));
        Institutions.Add(new Institution("Victoria University", "Wellington", "New Zealand"));
        Institutions.Add(new Institution("Auckland University of Technology", "Auckland", "New Zealand"));
    }

	private void SeedDepartments()
	{
		Departments.Add(new Department("Information Technology", 1, Institutions[0]));
		Departments.Add(new Department("Maths", 2, Institutions[1]));
		Departments.Add(new Department("Business", 3, Institutions[2]));
    }

	private void SeedCourses()
	{
		Courses.Add(new Courses("ID511001", "Programming 2", "Makes the windows form", 1000, 799.99, Courses[0]));
		Courses.Add(new Courses("B22141", "Business 101", "Learn to make the business", 1000, 999.99, Courses[0]));
		Courses.Add(new Courses("Web101", "Web Development", "Make website", 1000, 649.00, Courses[1]));
	}

	
}
