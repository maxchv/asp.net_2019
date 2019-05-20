using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson14.Models
{
    public class WorkerRepository
    {
        public static WorkerRepository Instance { get; } = new WorkerRepository();

        public List<Worker> Workers { get; } = new List<Worker>();
    }
}