using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.SocialMedia;

namespace Api.Domain.Dtos.Speaker
{
    public class SpeakerDto
    {
        public Guid? Id { get; set; }
        public string SpeakerName { get; set; }
        public string MiniResume { get; set; }
        public string ImagePath { get; set; }
        public string SpeakerPhone { get; set; }
        public string SpeakerEmail { get; set; }
        public IEnumerable<SocialMediaDto> SocialMedias { get; set; }
        public IEnumerable<SpeakerDto> Speakers { get; set; }
        public DateTime? CreatedAt { get; }
        public DateTime? UpdatedAt { get; }
    }
}

