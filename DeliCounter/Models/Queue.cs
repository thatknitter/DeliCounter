using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DeliCounter.Models
{
    public class Queue
    {
        int QueueId { get; set; }
        string Name { get; set; }
        int Position { get; set; }
        Boolean IsCurrent { get; set; }
        DateTime TimeServed { get; set; }
        DateTime TimeAquired { get; set; }
    }

    public class QueueContext : DbContext
    {
        DbSet<Queue> People { get; set; }

    }
}