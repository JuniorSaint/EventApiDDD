using System;
namespace Api.Domain.Models
{
    public class SpeakerModel : BaseModel
    {

        public string SpeakerName { get; set; }
        private string _speakerName
        {
            get { return _speakerName; }
            set { _speakerName = value; }
        }
        public string MiniResume { get; set; }
        private string _miniResume
        {
            get { return _miniResume; }
            set { _miniResume = value; }
        }

        public string SpeakerImage { get; set; }
        private string _speakerImage
        {
            get { return _speakerImage; }
            set { _speakerImage = value; }
        }

        public string SpeakerPhone { get; set; }
        private string _speakerPhone
        {
            get { return _speakerPhone; }
            set { _speakerPhone = value; }
        }

        public string SpeakerEmail { get; set; }
        private string _speakerEmail
        {
            get { return _speakerEmail; }
            set { _speakerEmail = value; }
        }

    }
}

