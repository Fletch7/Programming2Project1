namespace Programming2Project1;


using System;
using System.Collections.Generic;


public class Department(string name, int courseid, Institution institution)
{
    public string Name { get; } = name;
    public int courseID { get; set; } = courseid;
    public Institution institution { get; } = institution;
}

