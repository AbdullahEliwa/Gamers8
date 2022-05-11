﻿using AutoMapper;
using Booking.Application.Common.Mappings;
using Booking.Core.ValueObjects;
using Gamers8.Core.Repositories;
using Gamers8.Core.Shared;
using MediatR;
using summitDomain = Gamers8.Core.Entities.SummitAggregate;
namespace Gamers8.Api.Features.SummitsFeature.Summit.Admin
{

    public static class Create
    {
        public record Command(string titleAr, string titleEn,
                                  string defaultImagePathAr, string defaultImagePathEn,
                                  SeasonZones seasonZone,
                                  DateTime start, DateTime end,
                                  string programFilePathAr, string programFilePathEn,
                                  byte? ageGroupFrom,
                                  bool requireSignup,
                                  bool isIncludedInEntranceTicket,
                                  bool isFeaturedEvent,
                                  string factsSheetAr, string factsSheetEn)
            : IRequest<string>
        {
            public void Mapping(Profile profile)
            {
                profile.CreateMap<Command, summitDomain.Summit>()
                    .ForMember(s => s.Title, obj => obj.MapFrom(c => new DescriptionLocalized(c.titleAr, c.titleEn)))
                    .ForMember(s => s.Title, obj => obj.MapFrom(c => new DescriptionLocalized(c.titleAr, c.titleEn)));


            }
        }
        public class CommandHandler : IRequestHandler<Command, string>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public CommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                await _unitOfWork.Summits.Add(_mapper.Map<summitDomain.Summit>(request));
                return "success";
            }

        }





    }
}
