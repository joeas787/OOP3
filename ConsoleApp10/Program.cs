using System.Reflection.Metadata;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] Emp = new Employee[3];

            Emp[0] = new Employee(1,"Ali",'M',12000,Security.DBA,1,1,2001);
            Emp[1] = new Employee(2,"Joe",'M',8000,Security.Guest,2,2,2002);
            Emp[2] = new Employee(3,"Sara",'F',15000,Security.Developer,3,3,2003);
            foreach(Employee emp in Emp) 
                Console.WriteLine(emp.FullDisplay());

            
            
        }
    }
}
public class HireDate
{
    private int Day;
    public int dayy
    {
        get { return Day; }
        set {
            if (value >= 1 && value <= 31)
                Day = value;
            else
                throw new Exception("Not valid");

        }

    }
    private int Month;
    public int monthh
    {
        get { return Month; }
        set
        {

            if (value >= 1 && value <= 12)
                Month = value;
            else
                throw new Exception("Not valid");

        }
        
    }
    private int Year;
    public int yearr
    {
        get {return Year; }
        set {

            if (value <= 2025)
                Year = value;
            else
                throw new Exception("Not valid");


        }

    }

    public HireDate(int day, int month, int year)
    {
            dayy = day;
            monthh = month;
            yearr=year;
    }

    public string display()
    {
        return $"{Day}/{Month}/{Year}";
    }
}
public enum Security
{
    Guest,
    Developer,
    Secretary,
    DBA
}
public class Employee: HireDate
{

    private int ID;
    public int idd
    {
        get { return ID; }
        set {


            if(value>0) 
            ID = value;
            else
            throw new Exception("Not valid");

        }



    }

    public string Name { get; set; }

    private char gender;
    public char Gender
    {
        get { return gender; }
        set
        {
            if (value == 'M' || value == 'F')
                gender = value;
            else
                throw new Exception("Exception");

        }
    }
    private double Salary;
    public double salary
    {


        get { return Salary; }
        set
        {
            if (value < 0)
                salary = value;
            else
             throw new Exception("Not valid");
            

        }
    }
    public Security security { get; set; }
    public Employee(int id, string name, char gender, double salary, Security Security,int day,int month,int year):
        base(day,month,year)
    {
        idd = id;
        Name = name;
        Gender = gender;
        Salary = salary;
        security = Security;
    }
    public string FullDisplay()
    {
        return $"id: {ID}, Name: {Name}, Gender:{Gender}, salary: {Salary}, Security: {security}, HireDate: {display()}";
    }


}