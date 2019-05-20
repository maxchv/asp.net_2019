using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using lesson14.Models;

namespace lesson14.Controllers
{
    public class WorkerController : ApiController
    {
        private WorkerRepository _workerRepository = WorkerRepository.Instance;

        // GET: api/Worker
        public IEnumerable<Worker> Get(int size = 20, int page = 1)
        {
            
            return _workerRepository.Workers.Skip((page-1)*size).Take(size);
        }

        // GET: api/Worker/5
        public Worker Get(int id)
        {
            return _workerRepository.Workers.FirstOrDefault(w => w.Id == id);
        }

        // POST: api/Worker
        public int Post([FromBody] Worker worker)
        {
            worker.Id = _workerRepository.Workers.Count + 1;
            _workerRepository.Workers.Add(worker);
            StatusCode(HttpStatusCode.Created);
            return worker.Id;
        }

        // PUT: api/Worker/5
        public Worker Put(int id, [FromBody]Worker update)
        {
            var worker = _workerRepository.Workers.FirstOrDefault(w => w.Id == id);
            if (worker != null)
            {
                worker.Name = update.Name ?? worker.Name;
                worker.Salary = update.Salary;
            }

            return worker;
        }

        // DELETE: api/Worker/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var worker = _workerRepository.Workers.FirstOrDefault(w => w.Id == id);
                _workerRepository.Workers.Remove(worker);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok();
        }
    }
}
