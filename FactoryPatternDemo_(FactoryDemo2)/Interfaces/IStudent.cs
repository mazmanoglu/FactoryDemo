namespace FactoryPatternDemo__FactoryDemo2_.Interfaces
{
    public interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string SupervisorEmailAddress { get; set; }
        string SupervisorPhone { get; set; }
    }
}