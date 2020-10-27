using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;


namespace TravelClient.Controllers
{
  public class ReviewsController : Controller
  {

    public IActionResult Index()
    {
      var allReviews = Review.GetReviews();
      return View(allReviews);
    }

    public IActionResult Details(int id)
    {
      Review model = Review.GetDetails(id);
      return View(model);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Review review)
    {
      Review.Post(review);
      return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
      Review model = Review.GetDetails(id);
      return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Review review)
    {
      Review.Put(review);
      return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
      Review model = Review.GetDetails(id);
      return View(model);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
      Review.Delete(id);
      return RedirectToAction("Index");
    }

    public IActionResult Popular()
    {
      var model = Review.GetPopularReviews();
      return View(model);
    }

    public IActionResult Random()
    {
      Review model = Review.GetRandomReview();
      return View(model);
    }

  }
}