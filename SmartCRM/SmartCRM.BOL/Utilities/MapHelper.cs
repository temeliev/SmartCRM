namespace SmartCRM.BOL.Utilities
{
    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.DAL;
    using SmartCRM.Resources;

    public static class MapHelper
    {
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
    }
}
