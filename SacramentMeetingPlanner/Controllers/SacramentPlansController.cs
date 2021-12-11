using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeeting.Models;

namespace SacramentMeetingPlanner.Controllers

{
    public class SacramentPlansController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public SacramentPlansController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: SacramentPlans
        public async Task<IActionResult> Index(int? id)
        {
            if (id != null)
            {

            }

            return View(await _context.SacramentPlan.ToListAsync());
        }

        // GET: SacramentPlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            var sacramentPlan = await _context.SacramentPlan
                .Include(s => s.Speakers)
                .Include(s => s.OpeningHymn)
                .Include(s => s.SacramentHymn)
                .Include(s => s.ClosingHymn)
                .Include(s => s.BishopricMember)
                .FirstOrDefaultAsync(m => m.SacramentPlanId == id);
            if (sacramentPlan == null)
            {
                return NotFound();
            }

            return View(sacramentPlan);
        }

        // GET: SacramentPlans/Create
        public IActionResult Create()
        {
            ViewData["HymnId"] = new SelectList(_context.Set<Hymn>(), "HymnId", "HymnName");
            ViewData["BishopricMemberId"] = new SelectList(_context.Set<BishopricMember>(), "BishopricMemberId", "BishopricMemberName");
            return View();
        }

        // POST: SacramentPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SacramentPlanId,Date,BishopricMemberId,OpeningHymnId,ClosingHymnId,SacramentHymnId,IntermediateHymnId,OpeningPrayer,ClosingPrayer")]
         SacramentPlan sacramentPlan, string[] SpeakerName, string[] Topic)

        {
            sacramentPlan.Speakers = new List<Speaker>();

            foreach (var speaker in SpeakerName)
            {
                var index = 0;
                var addSpeaker = new Speaker
                {
                    Name = speaker,
                    Topic = Topic[index],
                    SacramentPlanId = sacramentPlan.SacramentPlanId
                };

                index++;
                sacramentPlan.Speakers.Add(addSpeaker);
            }


            if (ModelState.IsValid)
            {
                _context.Add(sacramentPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacramentPlan);
        }

        // GET: SacramentPlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["HymnId"] = new SelectList(_context.Set<Hymn>(), "HymnId", "HymnName");
            ViewData["BishopricMemberId"] = new SelectList(_context.Set<BishopricMember>(), "BishopricMemberId", "BishopricMemberName");

            if (id == null)
            {
                return NotFound();
            }

            var sacramentPlan = await _context.SacramentPlan
                .Include(s => s.Speakers)
                .FirstOrDefaultAsync(s => s.SacramentPlanId == id);
            if (sacramentPlan == null)
            {
                return NotFound();
            }

            return View(sacramentPlan);
        }

        //THIS ONE WORKS FOR THE SPEAKERS

        // POST: SacramentPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(
        "SacramentPlanId, Date, BishopricMemberId, OpeningHymnId, OpeningPrayer, SacramentHymnId, IntermediateHymnId , ClosingHymnId, ClosingPrayer")]
        SacramentPlan sacramentPlan, string[] SpeakerName, string[] Topic)
        {
            if (id != sacramentPlan.SacramentPlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var sacramentPlanToUpdate = await _context.SacramentPlan
                .Include(s => s.Speakers)
                .FirstOrDefaultAsync(s => s.SacramentPlanId == id);

                _context.Entry(sacramentPlanToUpdate).CurrentValues.SetValues(sacramentPlan);

                //Add a test for if sacrament plan is empty
                foreach (var speaker in sacramentPlanToUpdate.Speakers)
                {
                    _context.Speaker.Remove(speaker);
                }

                _context.SaveChanges();
                //sacramentPlan.Speakers.Remove();

                sacramentPlanToUpdate.Speakers = new List<Speaker>();

                var index = 0;

                foreach (var speaker in SpeakerName)
                {
                    var addSpeaker = new Speaker
                    {
                        Name = speaker,
                        Topic = Topic[index]
                        //SacramentPlanId = sacramentPlanToUpdate.SacramentPlanId
                    };

                    index++;
                    sacramentPlanToUpdate.Speakers.Add(addSpeaker);
                }

                try
                {

                    _context.Update(sacramentPlanToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentPlanExists(sacramentPlanToUpdate.SacramentPlanId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                string url = "/SacramentPlans/Details/" + sacramentPlanToUpdate.SacramentPlanId;
                return Redirect(url);
            }
            return View(sacramentPlan);
        }



        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, SacramentPlan SacramentPlan)
        // {
        //     if (id != SacramentPlan.SacramentPlanId)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(SacramentPlan);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!SacramentPlanExists(SacramentPlan.SacramentPlanId))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         string url = "/SacramentPlans/Details/" + SacramentPlan.SacramentPlanId;
        //         return Redirect(url);
        //     }
        //     ViewData["SacramentPlanId"] = new SelectList(_context.SacramentPlan, "SacramentPlanId", "SacramentPlanId", SacramentPlan.SacramentPlanId);
        //     return View(SacramentPlan);
        // }




        //THIS EDIT ONE WORKS. BUT THE SPEAKERS ARE NOT UPDATING

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("SacramentPlanId,Date,BishopricMemberId,OpeningHymnId,ClosingHymnId,SacramentHymnId,IntermediateHymnId,OpeningPrayer,ClosingPrayer,SpeakerSubject,Speakers")]
        // SacramentPlan sacramentPlan)
        // {
        //     if (id != sacramentPlan.SacramentPlanId)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(sacramentPlan);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!SacramentPlanExists(sacramentPlan.SacramentPlanId))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         string url = "/SacramentPlans/Details/" + sacramentPlan.SacramentPlanId;
        //         return Redirect(url);
        //     }
        //     ViewData["SacramentPlanId"] = new SelectList(_context.SacramentPlan, "SacramentPlanId", "SacramentPlanId", sacramentPlan.SacramentPlanId);
        //     return View(sacramentPlan);
        // }




        // GET: SacramentPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentPlan = await _context.SacramentPlan
                .Include(s => s.Speakers)
                .Include(s => s.OpeningHymn)
                .Include(s => s.SacramentHymn)
                .Include(s => s.ClosingHymn)
                .Include(s => s.BishopricMember)

                .FirstOrDefaultAsync(m => m.SacramentPlanId == id);
            if (sacramentPlan == null)
            {
                return NotFound();
            }

            return View(sacramentPlan);
        }


        // POST: SacramentPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacramentPlan = await _context.SacramentPlan.FindAsync(id);
            _context.SacramentPlan.Remove(sacramentPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool SacramentPlanExists(int id)
        {
            return _context.SacramentPlan.Any(e => e.SacramentPlanId == id);
        }
    }
}
