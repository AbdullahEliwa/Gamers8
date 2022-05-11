using AutoMapper;
using Booking.Core.ValueObjects;
using Gamers8.Api.Configurations.Mapping;
using Gamers8.Core.Entities.AttractionsAggregate;
using Gamers8.Core.Shared;
using MediatR;

namespace Gamers8.Api.Features.AttractionFeature.Admin
{
    public static class Create
    {
        public record Command() : IRequest<Result<string>> ,IMapFrom<Attraction>
        {
            public string TitleAr { get; init; }
            public string TitleEn { get; init; }

            public AttractionCategories AttractionCategory { get; init; }
            public string DefaultImagePath { get; init; }
            public string Description { get; init; }
            public SeasonZones SeasonZone { get; init; }
            public DateTime StartTime { get; init; }
            public DateTime EndTime { get; init; }
            public string OpeningTimes { get; init; }
            public int AgeGroupFrom { get; init; }
            public bool IncludedInEntranceTicket { get; init; }
            public bool RequiresSignup { get; init; }
            public bool IsFeaturedEvent { get; init; }

            public void Mapping(Profile profile) 
            {
                profile.CreateMap<Command, Attraction>()
                    .ForMember(a => a.Title, obj => obj.MapFrom(c => new DescriptionLocalized(c.TitleAr, c.TitleEn)))
                    .ForMember(a => a.DateTime.Start, obj => obj.MapFrom(c =>StartTime ))
                    .ForMember(a => a.DateTime.End, obj => obj.MapFrom(c => EndTime))
                    ;



            }

        }


    }
}
