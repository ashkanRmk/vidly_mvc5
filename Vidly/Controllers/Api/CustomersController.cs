using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/customers
        public IEnumerable<CustomerDto> GetCustomers() 
            => _context.customers
            .Include(m => m.MembershipType)
            .ToList()
            .Select(Mapper.Map<Customers, CustomerDto>);

        //GET /api/customers/{id}
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.customers.SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customers, CustomerDto>(customer));
        }

        //POST /api/customers
        //[HttpPost]
        //public Customers CreateCustomer(Customers customer)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    _context.customers.Add(customer);
        //    _context.SaveChanges();

        //    return customer;
        //}

        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customers>(customerDto);

            _context.customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id),customerDto);
        }

        //PUT /api/customers/{id}
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.customers.SingleOrDefault(m => m.Id == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();
            return Ok();
        }

        //DELETE /api/customers/{id}
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.customers.SingleOrDefault(m => m.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
