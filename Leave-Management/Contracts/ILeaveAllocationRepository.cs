﻿using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Contracts
{
    interface ILeaveAllocationRepository :IRepositoryBase<LeaveAllocation>
    {
    }
}
