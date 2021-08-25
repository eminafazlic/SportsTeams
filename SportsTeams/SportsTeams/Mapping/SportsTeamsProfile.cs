using AutoMapper;
using SportsTeams.Model.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Mapping
{
    public class SportsTeamsProfile : Profile
    {
        public SportsTeamsProfile()
        {
            CreateMap<Database.Country, Model.Country>();
            CreateMap<Model.Country, CountryUpdateRequest>();
            CreateMap<CountryUpdateRequest, Database.Country>();
            CreateMap<Database.Country, CountryInsertRequest>();
            CreateMap<CountryInsertRequest, Database.Country>();
            CreateMap<Database.Team, Model.Team>();
            CreateMap<Database.Team, TeamInsertRequest>();
            CreateMap<TeamInsertRequest, Database.Team>();
            CreateMap<Database.Team, TeamUpdateRequest>();
            CreateMap<TeamUpdateRequest, Database.Team>();
        }
    }
}
