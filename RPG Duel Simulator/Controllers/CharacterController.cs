using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPG_Duel_Simulator.Data;
using RPG_Duel_Simulator.Models;

namespace RPG_Duel_Simulator.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CharacterController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: CharacterController
        public IActionResult Index()
        {
            IEnumerable<Character> objCharacterList = _db.Characters.ToList();
            return View(objCharacterList);
        }

        // GET: CharacterController/Details/5
        public IActionResult Details(int? CharacterId)
        {
            if (CharacterId == null || CharacterId == 0)
            {
                return NotFound();
            }

            var characterFromDb = _db.Characters.Find(CharacterId);

            if (characterFromDb == null)
            {
                return NotFound();
            }
            return View(characterFromDb);
        }

        // GET: CharacterController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CharacterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Character obj)
        {
            if (ModelState.IsValid)
            {
                _db.Characters.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "New hero recruited";
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: CharacterController/Edit/5
        public IActionResult Edit(int? CharacterId)
        {
            if (CharacterId==null || CharacterId == 0)
            {
                return NotFound();
            }

            var characterFromDb = _db.Characters.Find(CharacterId);

            if (characterFromDb == null)
            {
                return NotFound();
            }
            return View(characterFromDb);
        }

        // POST: CharacterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Character obj)
        {
            if (ModelState.IsValid)
            {
                _db.Characters.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Fighter succesfully retrained";
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: CharacterController/Delete/5
        public IActionResult Delete(int? CharacterId)
        {
            if (CharacterId == null || CharacterId == 0)
            {
                return NotFound();
            }

            var CharacterFromDb = _db.Characters.Find(CharacterId);

            if (CharacterFromDb == null)
            {
                return NotFound();
            }
            return View(CharacterFromDb);
        }

        // POST: CharacterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? CharacterId)
        {
            var obj = _db.Characters.Find(CharacterId);

            if (obj == null) 
            {
                return NotFound();
            }

            _db.Characters.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Character vanished to the shadowrealm";
            return RedirectToAction("Index");
        }
    }
}
