using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetVet.Domain.Entities;
using NetVet.Domain.Repositories;
using NetVet.Models;
using PagedList.Core;

namespace NetVet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string dateTime, string petName, string ownersName, string contact, int? pageNumber)
        {
            var search = new SearchData() { 
                DateTime = dateTime,
                PetName = petName,
                OwnersName = ownersName,
                Contact = contact
            };
            IAppointmentRepository repository = new MockAppointmentRepository();
            var query = repository.GetAppointments();


                if (dateTime != null)
                    query = query.Where(x => x.AppointmentDateTime.Date == Convert.ToDateTime(dateTime));

                if (petName != null)
                    query = query.Where(x => x.Pet.Name.ToLower() == petName.ToLower());

                if (ownersName != null)
                    query = query.Where(x => x.Pet.Owner.FirstName.Contains(ownersName) || x.Pet.Owner.LastName.Contains(ownersName));

                if (contact != null)
                    query = query.Where(x => x.Pet.Owner.Contacts.Any(y => y.IsPreferred && y.ContactData.ToLower() == contact.ToLower()));
            

            search.AppointmentDetails = TurnIntoAppointment(query.ToList()).ToPagedList(pageNumber ?? 1, 25);
            return View(search);
        }

        private IQueryable<AppointmentDetails> TurnIntoAppointment(List<Appointment> appointments)
        {
            var appointmentList = new List<AppointmentDetails>();
            appointments.ForEach(x => {
                appointmentList.Add(new AppointmentDetails()
                {
                    Appointment = x.AppointmentDateTime,
                    OwnersName = $"{x.Pet.Owner.FirstName} {x.Pet.Owner.LastName}",
                    PetName = x.Pet.Name,
                    PreferedContactDetails = x.Pet.Owner.Contacts.FirstOrDefault(y => y.IsPreferred).ContactData
                });
            });
            return appointmentList.AsQueryable();
        }
    }
}
