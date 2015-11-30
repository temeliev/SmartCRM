namespace SmartCRM.BOL.Utilities
{
    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.DAL;
    using SmartCRM.Resources;

    public static class MapHelper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserModel>()
                    .ForMember(dest => dest.Employee, opt => opt.Ignore());
                cfg.CreateMap<UserModel, User>()
                    .ForMember(dest => dest.Employee, opt => opt.Ignore());

                cfg.CreateMap<Employee, EmployeeModel>()
                    .ForMember(dest => dest.Gender, opt => opt.Ignore());
                cfg.CreateMap<EmployeeModel, Employee>()
                    .ForMember(dest => dest.Gender, opt => opt.Ignore());

                cfg.CreateMap<Project, ProjectModel>()
                    .ForMember(dest => dest.Employees, opt => opt.Ignore())
                    .ForMember(dest => dest.Status, opt => opt.Ignore());
                cfg.CreateMap<ProjectModel, Project>()
                    .ForMember(dest => dest.Employees, opt => opt.Ignore())
                    .ForMember(dest => dest.Status, opt => opt.Ignore());

                cfg.CreateMap<ProjectCategoryModel, ConstProjectCategory>();
                cfg.CreateMap<ConstProjectCategory, ProjectCategoryModel>();
            });
        }

        public static void Map(EmployeeModel source, Employee destination)
        {
            Mapper.Map(source, destination);
            destination.Gender = (short)source.Gender;
           // destination.Photo = source.Photo; //ImagesHelper.ImageToByteArray(source.PhotoImage);
        }

        public static void Map(Employee source, EmployeeModel destination)
        {
            Mapper.Map(source, destination);
            destination.Gender = (GenderType)source.Gender;
           // destination.Photo = source.Photo;
           // destination.PhotoImage = ImagesHelper.ByteArrayToImage(source.Photo);
        }

        public static void Map(User source, UserModel destination)
        {
            Mapper.Map(source, destination);
        }

        public static void Map(UserModel source, User destination)
        {
            Mapper.Map(source, destination);
        }

        public static void Map(Project source, ProjectModel destination)
        {
            Mapper.Map(source, destination);
            destination.Status = (ProjectStatus)source.Status;
        }

        public static void Map(ProjectModel source, Project destination)
        {
            Mapper.Map(source, destination);
            destination.Status = (short)source.Status;
        }

        public static void Map(System.Linq.IQueryable<ConstProjectCategory> source, System.ComponentModel.BindingList<ProjectCategoryModel> destination)
        {
            Mapper.Map(source, destination);
        }
    }
}
