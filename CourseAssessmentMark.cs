namespace Programming2Project1;
using System.Collections.Generic;
using System.IO;

public class CourseAssessmentMark
{
    private Course _course;
    private List<int> _marks;

    public Course Course => _course;
    public List<int> Marks => _marks;

    public CourseAssessmentMark(Coruse course, List<int> marks)
    {
        _course = course;
        _marks = marks;
    }

    public List<int> GetAllMarks()
    {
        return _marks;
    }

    private string GetGrade()
    {
        if (_marks => 90) { return $"Nice! Your mark of {_marks} is an A+!"}
        else if (_marks => 85) { return $"Your mark of {_marks} is an A"}
        else if (_marks => 80) { return $"Your mark of {_marks} is an A-"}
        else if (_marks => 75) { return $"Your mark of {_marks} is an B+"}
        else if (_marks => 70) { return $"Your mark of {_marks} is an B"}
        else if (_marks => 65) { return $"Your mark of {_marks} is an B-"}
        else if (_marks => 60) { return $"Your mark of {_marks} is an C+"}
        else if (_marks => 55) { return $"Your mark of {_marks} is an C"}
        else if (_marks => 50) { return $"Your mark of {_marks} is an C-"}
        else if (_marks => 40( { return "D - failed assessment."})
        else { return "E - super failed assessment."}
    }

}

