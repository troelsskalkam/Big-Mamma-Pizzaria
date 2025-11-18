public class Employee
{
    private int _employeeId;
    private string _name;

    public Employee(int employeeId, string name)
        { 
        _employeeId = employeeId;
        _name = name; 
    }

    public int EmployeeId
    {
        get { return _employeeId; }
    }
    public string Name
    {  
        get { return _name; } 
    }


}
