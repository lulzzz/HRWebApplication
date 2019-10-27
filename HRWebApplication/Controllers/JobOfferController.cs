﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRWebApplication.Models;

namespace HRWebApplication.Controllers
{
    [Route("[controller]/[action]")]
    public class JobOfferController : Controller
    {
        private static List<JobOffer> jobOffer = new List<JobOffer>
            {
                new Models.JobOffer() { Id = 1, Title= "Plumber", Overview="Looking for experienced plumber.", Specialization = "Plumber", Location = "Paris",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.EUR, AddedOn = DateTime.Now},
                new Models.JobOffer() { Id = 2, Title= "Advanced Plumber",Overview = "Looking for Mario.", Specialization = "Plumber", Location = "Warsaw",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.PLN, AddedOn = DateTime.Now},
                new Models.JobOffer() { Id = 3, Title= "Senior Plumber",Overview = "Looking for senior plumber.", Specialization = "Plumber", Location = "London",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.GBP, AddedOn = DateTime.Now},
                new Models.JobOffer() { Id = 4, Title= "Senior Plumber",Overview = "Looking for senior plumber.", Specialization = "Plumber", Location = "London",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.GBP, AddedOn = DateTime.Now},
                new Models.JobOffer() { Id = 5, Title= "Senior Plumber",Overview = "Looking for senior plumber.", Specialization = "Plumber", Location = "London",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.GBP, AddedOn = DateTime.Now},
                new Models.JobOffer() { Id = 6, Title= "Senior Plumber",Overview = "Looking for senior plumber.", Specialization = "Plumber", Location = "London",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.GBP, AddedOn = DateTime.Now},
                new Models.JobOffer() { Id = 7, Title= "Senior Plumber",Overview = "Looking for senior plumber.", Specialization = "Plumber", Location = "London",
                    SalaryFrom = 1000, SalaryTo = 3000, Currency = Currency.GBP, AddedOn = DateTime.Now},
            };

        public IActionResult Index()
        {
            return View(jobOffer);
        }

        public IActionResult Details(int id)
        {
            var offer = jobOffer.FirstOrDefault(o => o.Id == id);
            return View(offer);
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest($"id should not be null");
            }

            jobOffer.RemoveAll((jobOffer) => id == jobOffer.Id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Create()
        {
            var model = new CreateJobOfferViewModel
            {
                Companies = await _context.Companies.ToListAsync()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateJobOfferViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Companies = await _context.Companies.ToListAsync();
                return View(model);
            }

            JobOffer jo = new JobOffer
            {
                CompanyId = model.CompanyId,
                Description = model.Description,
                Title = model.Title,
                Location = model.Location,
                SalaryFrom = model.SalaryFrom,
                SalaryTo = model.SalaryTo,
                ValidUntil = model.ValidUntil,
                AddedOn = DateTime.Now
            };

            await _context.JobOfers.AddAsync(jo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}