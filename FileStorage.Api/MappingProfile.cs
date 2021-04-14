using AutoMapper;
using FileStorage.Api.Database.Entities;
using FileStorage.Api.Models;

namespace FileStorage.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IncomingFile, File>()
                .ForMember(a => a.Id, expression => expression.Ignore())
                .ForMember(a => a.FullPath, expression => expression.MapFrom(b => b.Path));

            CreateMap<File, OutgoingFile>();

            CreateMap<File, OutgoingFileInfo>();
        }
    }
}
