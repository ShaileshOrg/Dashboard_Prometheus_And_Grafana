using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dashboard_Prometheus_And_Grafana.Database;
using Dashboard_Prometheus_And_Grafana.Model;

namespace Dashboard_Prometheus_And_Grafana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerRepository repository;
        public CustomerController(CustomerRepository repository)
        {
            this.repository = repository;
        }
        //Get all customers
        [HttpGet("customers")]
        public IEnumerable<Customer> Customers()
        {
            return repository.customers;
        }

        [HttpGet("customers/{Id}")]
        public Customer GetCustomer(int Id)
        {
            return repository.customers.Where(x => x.Id == Id).FirstOrDefault();
        }

        [HttpPost("customers/create")]
        public Customer CreateCustomer([FromBody] Customer customer)
        {
            var customers = repository.customers;
            customers.Add(customer);
            return customer;

        }
    }
}
