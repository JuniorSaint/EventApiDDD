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

        public string Thema { get; set; }
        private string _thema
        {
            get { return _thema; }
            set { _thema = value; }
        }

        public int PeopleAmount { get; set; }
        private int _peopleAmount
        {
            get { return _peopleAmount; }
            set { _peopleAmount = value; }
        }

        public string ImagePath { get; set; }
        private string _imagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
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

