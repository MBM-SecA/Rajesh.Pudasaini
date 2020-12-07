using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


public class DepartmentController: Controller 
{

    private readonly EMSContext db;
    public DepartmentController(EMSContext _db){
        //construction injection
        db = _db;
    }

    public ActionResult Index() {
        var departments = db.Department.ToList();
        // var persons = Person.GetEmployee();
        return View(departments);
    }

    public ActionResult Add(){
        return View();
    }

    [HttpPost]
    public ActionResult Add(Department department){
        db.Department.Add(department);
        db.SaveChanges();
        // return Redirect("/employee");
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Update(int id){

        var department = db.Department.Find(id);
        return View(department);
    }

    

    [HttpPost]
    public ActionResult Update(Department department){
        
        db.Department.Attach(department);
        db.Department.Update(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id){

        var department = db.Department.Find(id);
        return View(department);
    }

    [HttpPost]
    public ActionResult Delete(Department department){
        db.Department.Attach(department);
        db.Department.Remove(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }


}