using AutoMapper;
using Booking.Application.Common.Mappings;
using Gamers8.Core.Repositories;
using MediatR;
using summitDomain = Gamers8.Core.Entities.SummitAggregate;

namespace Gamers8.Api.Features.SummitsFeature.SummitDay.Admin
{
    public static class Create
    {
        public class Command : IRequest<string>, IMapFrom<summitDomain.SummitDay>
        {
            public DateTime Date { get; init; }

            public void Mapping(Profile profile)
            {
                profile.CreateMap<Command, summitDomain.SummitDay>()
                    .ForMember(s => s.Date, obj => obj.MapFrom(c => c.Date));


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
                var x = _mapper.Map<summitDomain.SummitDay>(request);

                await _unitOfWork.SummitDays.Add(x);
                await _unitOfWork.Complete<int>();
                return "success";
            }
        }


    }
}
