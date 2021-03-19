using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_Prometheus_And_Grafana.Model;

namespace Dashboard_Prometheus_And_Grafana.Database
{
    public class CustomerRepository
    {
        public List<Customer> customers { get; set; } = new List<Customer>
        {
            new Customer() { Id=1, FirstName="John", Age=10 },
            new Customer() { Id=2, FirstName="Mark", Age=20 },
            new Customer() { Id=3, FirstName="Jeff", Age=15 },
            new Customer() { Id=4, FirstName="Tyler", Age=14 },
            new Customer() { Id=5, FirstName="Bradley", Age=22 },
            new Customer() { Id=6, FirstName="Scott", Age=30 },
            new Customer() { Id=7, FirstName="Ryan", Age=40 },
            new Customer() { Id=8, FirstName="Tommy", Age=45 },
        };
    }
}
