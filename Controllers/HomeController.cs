using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{

    //==========================
    //       Index metodu
    //==========================
    public IActionResult Index()
    {
        ViewBag.CafeteriaName = "Sakarya University Cafeteria";
        ViewBag.CurrentDate = DateTime.Now.ToString("dd.MM.yyyy");

        // 2. Sadece "Collected" (Teslim alınmış) olan siparişleri buluyoruz
        // Repository.Orders, hocanın projeye koyduğu 20 adet hazır veridir(Repository.cs içinde).
        var collectedOrders = Repository.Orders.Where(order => order.Collected == true).ToList();

        // 3. Bulduğumuz bu teslim alınmış yemek listesini View'a gönderiyoruz
        return View(collectedOrders);


    }


    //=========================
    //    AllOrders metodu
    //==========================
    public IActionResult AllOrders()
    {
        //tüm listeyi alır
        var allMeals = Repository.Orders;
        //sayfaya gönderir
        return View(allMeals);
    }


    //==========================
    // CollectonInfo metodu
    //==========================
    public IActionResult CollectionInfo(string id)
    {
        var bulunanSiparis = Repository.Orders.FirstOrDefault(x => x.OrderID == id);
        return View(bulunanSiparis);
    }


    //=========================
    // CollectMeal  GET metodu
    //=========================
    public IActionResult CollectMeal()
    {
        //sadece form göndereceğim bu yüzden içi boş olmalı
        return View();
    }


    //==========================
    // CollectMeal POST Metodu
    //==========================
    [HttpPost]//formdan veri geldiğinde çalışması için
    public IActionResult CollectMeal(string OrderID)
    {
        //model Binding burada
        //formdan gelen _OrderID iel listeyi tarayıp o siparişi buluyorum
        var siparis = Repository.Orders.FirstOrDefault(x => x.OrderID == OrderID);

        if (siparis != null && siparis.Collected == false)//sipariş gerçekten varsa ve daha önce teslim alınmamışsa
        {
            siparis.Collected = true;
            siparis.CollectedAt = DateTime.Now;
        }

        return RedirectToAction("Index");

    }
}
