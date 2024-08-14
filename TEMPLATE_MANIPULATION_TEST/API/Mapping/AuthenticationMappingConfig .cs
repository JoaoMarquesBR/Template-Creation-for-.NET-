using Contracts.Requests;
using Domain.Entities;
using Mapster;

namespace API.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TEMPLATE_REGISTRATION_REQUEST, TEMPLATE_ENTITY_CLASS>()
                .Map(dest => dest.FirstName, src => src.firstName)
                .Map(dest => dest.LastName, src => src.lastName)
                .Map(dest => dest.UserEmail, src => src.email);
        }
    }
}
