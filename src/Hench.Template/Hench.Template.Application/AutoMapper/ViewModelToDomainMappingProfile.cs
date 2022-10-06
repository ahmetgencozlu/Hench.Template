using AutoMapper;

namespace Hench.Template.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //CreateMap<UserViewModel, RegisterNewUserCommand>()
            //    .ConstructUsing(c => new RegisterNewCustomerCommand(c.Name, c.Email, c.BirthDate));
            //CreateMap<UserViewModel, UpdatUserCommand>()
            //    .ConstructUsing(c => new UpdatUserCommand(c.Id, c.Name, c.Email, c.BirthDate));
        }
    }
}
