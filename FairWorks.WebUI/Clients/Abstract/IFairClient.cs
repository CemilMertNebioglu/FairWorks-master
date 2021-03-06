﻿using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Abstract
{
    public interface IFairClient
    {
        Task<FairDTO> AddFair(FairDTO fairDTO);
        Task<List<FairDTO>> GetAllFairs();
        
    }
}
