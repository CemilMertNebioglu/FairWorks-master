using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Models.Interview
{
    public class InterviewViewModel
    {
        public List<SectorDTO> Sectors { get; set; }
        public List<CompanyProfileDTO> CompanyProfiles { get; set; }
        public List<FairDTO> Fairs { get; set; }
        public List<SalonDTO> Salons { get; set; }
        public List<InterviewDTO> Interviews { get; set; }
        public List<InterviewFairDTO> InterviewFairs { get; set; }
        
    }
}
