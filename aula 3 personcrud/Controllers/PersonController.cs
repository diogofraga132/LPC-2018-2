using AutoMapper;
using crud_people.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_people.Controllers
{
    public class PersonController : Controller
    {
        PersonRepository _repository = new PersonRepository();

        public IActionResult Index()
        {
            var people = _repository.GetAll();
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonViewModel obj)
        {
            var person = Mapper.Map<Person>(obj);

            _repository.Create(person);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _repository.Update(person);
            return RedirectToAction("Index");
        }
       
    }
}