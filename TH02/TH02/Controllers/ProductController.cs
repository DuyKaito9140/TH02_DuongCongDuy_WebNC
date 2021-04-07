using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH02.Models;

namespace TH02.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetProduct()
        {
            List<Product> listpro = new List<Product>();
            Product pro1 = new Product();
            pro1.ID = "12345DFGDFD";
            pro1.Image = "Image/macbookpro2021.jpg";
            pro1.ProductName = "Macbook Pro 2021";
            pro1.ProductType = "Laptop";
            pro1.ProductPrice = 78000000;

            Product pro2 = new Product();
            pro2.ID = "TGCVHGX1234";
            pro2.Image = "Image/macbookpro2021.jpg";
            pro2.ProductName = "Iphone XS Max";
            pro2.ProductType = "Điện thoại";
            pro2.ProductPrice = 35000000;

            Product pro3 = new Product();
            pro3.ID = "LTD24827822";
            pro3.Image = "Image/dell-15-7591.png";
            pro3.ProductName = "Dell Inspiron 7591";
            pro3.ProductType = "Laptop";
            pro3.ProductPrice = 23000000;

            Product pro4 = new Product();
            pro4.ID = "873425FSBBH";
            pro4.Image = "Image/samsung-galaxy-note-10.jpg";
            pro4.ProductName = "Samsung Galaxy Note 10";
            pro4.ProductType = "Điện thoại";
            pro4.ProductPrice = 22000000;

            Product pro5 = new Product();
            pro5.ID = "JCBB5738221";
            pro5.Image = "Image/xiaomi-redmi-4x.png";
            pro5.ProductName = "Xiaomi Redmi Note 4x";
            pro5.ProductType = "Điện thoại";
            pro5.ProductPrice = 500000;


            listpro.Add(pro1);
            listpro.Add(pro2);
            listpro.Add(pro3);
            listpro.Add(pro4);
            listpro.Add(pro5);
            return View(listpro);
        }
    }
}