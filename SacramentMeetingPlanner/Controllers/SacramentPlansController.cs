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

            // get speakers
            // var speakers = await _context.Speaker
            //     .Include(s => s.Name)
            //     .Include(s => s.Topic)
            //     .Where(SacramentPlanId = id);

            // if (id == null)
            // {
            //     return NotFound();
            // }

            var sacramentPlan = await _context.SacramentPlan
                .Include(s => s.Speakers)
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
            return View();
        }

        // POST: SacramentPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SacramentPlanId,Date,ConductingLeader,OpenningHymn,ClosingHymn,SacramentHymn,MusicNumber,OpenningPrayer,ClosingPrayer,SpeakerSubject")]
         SacramentPlan sacramentPlan, Speaker[] selectedSpeakers)
        {
            sacramentPlan.Speakers = new List<Speaker>();

            foreach (var speaker in selectedSpeakers)
            {
                var addSpeaker = new Speaker
                {
                    SpeakerId = speaker.SpeakerId,
                    Name = speaker.Name,
                    Topic = speaker.Topic,
                    SacramentPlanId = sacramentPlan.SacramentPlanId
                };
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
            if (id == null)
            {
                return NotFound();
            }

            var sacramentPlan = await _context.SacramentPlan.FindAsync(id);
            if (sacramentPlan == null)
            {
                return NotFound();
            }
            return View(sacramentPlan);
        }

        // POST: SacramentPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SacramentPlanId,Date,ConductingLeader,OpenningHymn,ClosingHymn,SacramentHymn,MusicNumber,OpenningPrayer,ClosingPrayer,SpeakerSubject")] SacramentPlan sacramentPlan)
        {
            if (id != sacramentPlan.SacramentPlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacramentPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentPlanExists(sacramentPlan.SacramentPlanId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sacramentPlan);
        }

        // GET: SacramentPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentPlan = await _context.SacramentPlan
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
