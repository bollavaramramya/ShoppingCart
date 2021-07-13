using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using UI.Setup;
using OpenQA.Selenium;
using NUnit.Framework;


namespace UI.Objects
{
    [Binding]
    public class ShoppingObj : SetUpPage
    {
        private int i;

        public ShoppingObj() { }

        #region Element Locators 

        public IList<IWebElement> ShopProducts => driver.FindElements(By.XPath("//ul[@class='products columns-4']/li"));

        public IWebElement WishListMenu = driver.FindElement(By.XPath("//div[@class='header-right col-md-3 hidden-xs']//i[@class='lar la-heart']"));
        public IList<IWebElement> WishlistPname => driver.FindElements(By.XPath("//td[@class='product-name']"));

        public IList<IWebElement> WLTable => driver.FindElements(By.XPath("//tbody/tr"));

        public static IList<IWebElement> WishlistPprice => driver.FindElements(By.XPath("//td[@class='product-price']"));
        public IWebElement AddtocartButton => driver.FindElement(By.XPath("//div[@class='header-right col-md-3 hidden-xs']/div/div/div/a/i"));
        public IList<IWebElement> CartTableproductsrow => driver.FindElements(By.XPath("//table[starts-with(@class,'shop_table shop_table_responsive ')]/tbody/tr[@class]"));
        public IWebElement Productname => driver.FindElement(By.XPath("//table[starts-with(@class,'shop_table shop_table_responsive ')]/tbody/tr/td[3]"));


        #endregion


        public void addtowishlist()
        {
            for (i = 0; i <= 3; i++)
            {
                var AWL = ShopProducts[i].FindElement(By.XPath("//span[contains(text(),'Add to wishlist')]"));
               
                AWL.Click();
                Thread.Sleep(3000);
            }
        }

        public void ViewWishList()
        {
            WishListMenu.Click();
        }

        public void SelectedItems()
        {
            int count = WishlistPname.Count();
            Console.WriteLine(count);
            Assert.AreEqual(count, 4);
                            
        }  

        public void LowestP()
        {
            int cout1 = WishlistPprice.Count;
            var sortedWishlistpp = WishlistPprice.OrderBy(x => x.Text);
            var textsorted = sortedWishlistpp.First().Text;
            Console.WriteLine(textsorted + " is the lowest priced product");

        }

        public void Addlowstitemtocart()
        {
            int cout1 = WishlistPprice.Count;
            var sortedWishlistpp = WishlistPprice.OrderBy(x => x.Text);
            for (i = 0; i < cout1; i++)
            {
                var Col = WLTable[i].FindElements(By.TagName("td"));

                //int clocout = rowcount.Count;
                if (Col.Contains(sortedWishlistpp.First()))

                {
                    string addtocartxpath = "//tr[" + (i + 1) + "]/td/a[contains(text(),'Add to cart')]";
                    IWebElement Addtocart = driver.FindElement(By.XPath(addtocartxpath));

                    Addtocart.Click();
                    Thread.Sleep(1000);                                 

                }
            }
        }


        public void gotoCart1()
        {
            AddtocartButton.Click();
            Thread.Sleep(1000);
            int cartrowcount = CartTableproductsrow.Count;
            if(cartrowcount>0)
            {
               var Cartproductnaem = Productname.Text;
                Console.WriteLine(Cartproductnaem);
            }
            else
            { Console.WriteLine("NO PRODUCT ADDED TO SHOPPING CART. YOU FAILED"); }
        }

    }
}

    



