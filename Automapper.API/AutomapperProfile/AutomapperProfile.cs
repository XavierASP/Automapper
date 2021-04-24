using AutoMapper;

public class AutomapperProfile: Profile
{
    public AutomapperProfile()
    {
        //Source to destination.
        CreateMap<Employee,EmployeeDTO>();
    }
}