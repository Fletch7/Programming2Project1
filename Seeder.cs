namespace Programming2Project1;
using System;
using System.Collections.Generic;

public class Seeder
{
	private List<Institution> _institution;
	private List<Department> _departments;
	private List<Course> _courses;

	public List<Institution> Institutions => _institution;
	public List<Department> Departments => _departments;
    public List<Course> Courses => _courses;

	public Seeder()
	{
		_institution = SeedInstitutions();
		_departments = SeedDepartments();
		_courses = SeedCourses();
	}
	
	public static List<Institution> SeedInstitutions()
	{
		Institutions.Add(new Institution("Otago Polytech", "Otago", "New Zealand"));
        Institutions.Add(new Institution("Victoria University", "Wellington", "New Zealand"));
        Institutions.Add(new Institution("Auckland University of Technology", "Auckland", "New Zealand"));
    }

	public static List<Department> SeedDepartments()
	{
		Departments.Add(new Department("Information Technology", 1, Institutions[0]));
		Departments.Add(new Department("Maths", 2, Institutions[1]));
		Departments.Add(new Department("Business", 3, Institutions[2]));
    }

	public static List<Courses> SeedCourses()
	{
		Courses.Add(new Courses("ID511001", "Programming 2", "Makes the windows form", 1000, 799.99, Courses[0]));
		Courses.Add(new Courses("B22141", "Business 101", "Learn to make the business", 1000, 999.99, Courses[0]));
		Courses.Add(new Courses("Web101", "Web Development", "Make website", 1000, 649.00, Courses[1]));
	}

	
}
