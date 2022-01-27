namespace FactoryDemo.Interfaces
{
    public interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string SupervisorEmail { get; set; }
        string SupervisorPhone { get; set; }
    }
}