﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRWebApplication.Models;
using HRWebApplication.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HRWebApplication.Areas.HRUser.Controllers
{
    /// <summary>
    /// Job offer controller for HR user.
    /// </summary>
    [Area("HRUser")]
    [Authorize(Roles = "HRUser")]
    public class JobOfferController : Controller
    {
        private int pageSize = 3;
        private PaginationHelper paginationHelper = new PaginationHelper();


        private readonly DataContext _context;

        /// <summary>
        /// JobOfferController constructor.
        /// </summary>
        /// <param name="context"></param>
        public JobOfferController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Action gets the view containing list of job offers matching filters defined as parametrs.
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <param name="currentFilter"></param>
        /// <param name="searchString"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<PartialViewResult> GetJobOffers(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var jobOffers = from s in _context.JobOffers select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                jobOffers = jobOffers.Where(s => s.Title.Contains(searchString));
            }

            jobOffers = sortOrder switch
            {
                "name" => jobOffers.OrderBy(s => s.Title),
                "name_desc" => jobOffers.OrderByDescending(s => s.Title),
                "date" => jobOffers.OrderBy(s => s.AddedOn),
                "date_desc" => jobOffers.OrderByDescending(s => s.AddedOn),
                _ => jobOffers.OrderBy(s => s.Title),
            };

            int pageNumber = (page ?? 1);

            jobOffers = jobOffers.Where(s => s.CompanyId.ToString() == User.FindFirst(ClaimTypes.GroupSid).Value);

            ViewBag.CurrentPage = pageNumber;
            ViewBag.PagesCount = paginationHelper.GetPagesCount(pageSize, await jobOffers.CountAsync());
            List<JobOffer> jobOffersList = await jobOffers
                .Skip(paginationHelper.GetFirstIndexOnPage(pageSize, pageNumber))
                .Take(pageSize)
                .ToListAsync();

            JobOfferListViewModel jobOfferListViewModel = new JobOfferListViewModel()
            {
                JobOffers = jobOffersList,
                PendingOffers = new List<int>()
            };

            return PartialView("_JobOfferList", jobOfferListViewModel);
        }

        /// <summary>
        /// Displays main view for paging and filtering jobs offer.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            JobOfferViewModel jobOfferViewModel = new JobOfferViewModel();
            jobOfferViewModel.JobOffersCount = await _context.JobOffers.Where(s => s.CompanyId.ToString() == User.FindFirst(ClaimTypes.GroupSid).Value).CountAsync();

            return View(jobOfferViewModel);
        }

        /// <summary>
        /// Gets view with page to edit job offer with specified id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest($"id shouldn't not be null");
            }
            var offer = await _context.JobOffers.FirstOrDefaultAsync(x => x.Id == id.Value);

            if (offer == null)
            {
                return NotFound($"offer not found in DB");
            }

            return View(offer);
        }

        /// <summary>
        /// Validate and updates recived job offer in database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(JobOffer model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var offer = await _context.JobOffers.FirstOrDefaultAsync(x => x.Id == model.Id);
            offer.Title = model.Title;
            offer.Overview = model.Overview;
            offer.Location = model.Location;
            offer.SalaryFrom = model.SalaryFrom;
            offer.SalaryTo = model.SalaryTo;
            offer.Specialization = model.Specialization;
            offer.ValidUntil = model.ValidUntil;
            offer.Description = model.Description;
            offer.Currency = model.Currency;
            _context.Update(offer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "JobOffer", new { Area = "HRUser", id = model.Id });
        }

        /// <summary>
        /// Removes job offer from database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest($"id should not be null");
            }

            _context.JobOffers.Remove(new JobOffer() { Id = id.Value });
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "JobOffer", new { Area = "HRUser" });
        }

        /// <summary>
        /// Gets page with form to create new job offer .
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Create()
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.ProviderUserId == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var model = new CreateJobOfferViewModel
            {
                Companies = new List<Company>() { await _context.Companies.FirstOrDefaultAsync(x=>x.Id == user.CompanyId) }
            };

            return View(model);
        }

        /// <summary>
        /// Validates and saves recived to a database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateJobOfferViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            JobOffer jobOffer = new JobOffer
            {
                CompanyId = model.CompanyId,
                Overview = model.Overview,
                Description = model.Description,
                Title = model.Title,
                Location = model.Location,
                SalaryFrom = model.SalaryFrom,
                SalaryTo = model.SalaryTo,
                ValidUntil = model.ValidUntil,
                AddedOn = DateTime.Now,
                Specialization = model.Specialization,
                Currency = model.Currency,
            };

            await _context.JobOffers.AddAsync(jobOffer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "JobOffer", new { Area = "HRUser"});
        }

        /// <summary>
        /// Gets page with detailed information about job offer with specified id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int id)
        {
            var offer = await _context.JobOffers.FirstOrDefaultAsync(x => x.Id == id);
            if (offer is null)
            {
                return NotFound($"offer not found in DB");
            }
            return View(offer);
        }
    }
}