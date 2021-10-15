using System;
using Microsoft.Extensions.Primitives;

namespace Api.Domain.Models
{
    public class EventModel : BaseModel
    {

        public string Local { get; set; }
        private string _local
        {
            get { return _local; }
            set { _local = value; }
        }

        public DateTime EventDate { get; set; }
        private DateTime _eventDate
        {
            get { return _eventDate; }
            set { _eventDate = value; }
        }

        public TimeSpan EventTime { get; set; }
        private TimeSpan _eventTime
        {
            get { return _eventTime; }
            set { _eventTime = value; }
        }

        public string Theme { get; set; }
        private string _theme
        {
            get { return _theme; }
            set { _theme = value; }
        }

        public int PeopleAmount { get; set; }
        private int _peopleAmount
        {
            get { return _peopleAmount; }
            set { _peopleAmount = value; }
        }

        public string EventImage { get; set; }
        private string _eventImage
        {
            get { return _eventImage; }
            set { _eventImage = value; }
        }

        public string Phone { get; set; }
        private string _phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email { get; set; }
        private string _email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}

