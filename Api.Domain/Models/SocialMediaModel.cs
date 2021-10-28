
using System;
namespace Api.Domain.Models
{
    public class SocialMediaModel
    {

        public string SocialMedia { get; set; }
        private string _socialMedia
        {
            get { return _socialMedia; }
            set { _socialMedia = value; }
        }

        public string URL { get; set; }
        private string _url
        {
            get { return _url; }
            set { _url = value; }
        }

        public Guid? EventId { get; set; }
        private Guid? _eventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }

        public Guid? SpeakerId { get; set; }
        private Guid? _speakerId
        {
            get { return _speakerId; }
            set { _speakerId = value; }
        }

    }
}
