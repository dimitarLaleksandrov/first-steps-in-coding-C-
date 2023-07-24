using Homies.Data;
using Homies.Data.Models;
using Homies.Models;
using Homies.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Type = Homies.Data.Models.Type;

namespace Homies.Service
{
    public class EventServices : IEventServices
    {

        private readonly HomiesDbContext dbContext;

        public EventServices(HomiesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddEventAsync(AddEventFormModel eventModel, string userId)
        {
            Event _event = new Event
            {
                Name = eventModel.Name,
                Description = eventModel.Description,
                OrganiserId = userId,
                CreatedOn = eventModel.CreatedOn,
                Start = eventModel.Start,
                End = eventModel.End,
                TypeId = eventModel.TypeId,
                
            };

            await dbContext.Events.AddAsync(_event);

            await dbContext.SaveChangesAsync();
        }

        public async Task EdiEventAsync(int id, AddEventFormModel model)
        {
            var _event = await dbContext.Events.FindAsync(id);

            if (_event != null)
            {

                _event.Name = model.Name;
                _event.Description = model.Description;
                _event.CreatedOn = model.CreatedOn;
                _event.Start = model.Start;
                _event.End = model.End;
                _event.TypeId = model.TypeId;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<AddEventFormModel> GetAddEventFormModelAsync()
        {
            var types = await dbContext.Type
                                   .Select(x => new TypeViewModel
                                   {
                                      Id = x.Id,
                                      Name = x.Name,

                                   })
                                   .ToListAsync();

            var eventModel = new AddEventFormModel
            {
               Types = types
            };

            return eventModel;
        }

        public async Task<IEnumerable<AddEventFormModel>> GetAllEventsAsync()
        {
            return await this.dbContext
                 .Events
                 .Select(x => new AddEventFormModel
                 {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Organiser = x.Organiser,
                    CreatedOn = x.CreatedOn,
                    Start = x.Start,
                    End = x.End,
                    TypeId = x.TypeId,
                    Type = x.Type
                 })
                 .ToListAsync();
        }

      

        public async Task<AddEventFormModel?> GetEventByIdForEditAsync(int id)
        {
            var types = await dbContext.Type
                                       .Select(x => new TypeViewModel
                                       {
                                           Id = x.Id,
                                           Name = x.Name,
                                       })
                                       .ToListAsync();
            return await dbContext.Events
                 .Where(x => x.Id == id)
                 .Select(b => new AddEventFormModel
                 {
                     Name = b.Name,
                     Description = b.Description,
                     CreatedOn = b.CreatedOn,
                     Start = b.Start,
                     End = b.End,
                     TypeId = b.TypeId,
                     Types = types
                     
                 })
                 .FirstOrDefaultAsync();

        }

        public async Task Join(string userId, int eventId)
        {
            var eventParticipant = new EventParticipant
            {
                EventId = eventId,
                HelperId = userId,
            };

            await dbContext.EventParticipants.AddAsync(eventParticipant);

            dbContext.SaveChanges();
        }
    }
}
