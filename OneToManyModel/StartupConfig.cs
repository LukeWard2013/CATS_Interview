using AutoMapper;
using CATS_Interview.Model;
using CATS_Interview.View_Models;

namespace CATS_Interview
{
    public class StartupConfig
    {
        public static void CreateAutoMapperMaps()
        {
            Mapper.CreateMap<OperatorViewModel, Operator>().ForMember(m => m.Contacts, opt => opt.Ignore()).ForMember(
                m => m.Trucks, opt => opt.Ignore());
            Mapper.CreateMap<ContactViewModel, Contact>();
            Mapper.CreateMap<CallViewModel, Call>();
            Mapper.CreateMap<Contact, ContactViewModel>();
            Mapper.CreateMap<Operator, OperatorViewModel>();
        }
    }
}