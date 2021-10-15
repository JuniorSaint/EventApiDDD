using System;
namespace Api.Domain.Models
{
    public class LotModel : BaseModel
    {

        public string LotName { get; set; }
        private string _lotName
        {
            get { return _lotName; }
            set { _lotName = value; }
        }

        public decimal Price { get; set; }
        private decimal _price
        {
            get { return _price; }
            set { _price = value; }
        }

        public DateTime InitialDate { get; set; }
        private DateTime _initialDate
        {
            get { return _initialDate; }
            set { _initialDate = value; }
        }

        public DateTime EndDate { get; set; }
        private DateTime _endDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public int Amount { get; set; }
        private int _amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public Guid EventId { get; set; }
        private Guid _eventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }
    }
}

