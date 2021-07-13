using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UI.Objects;

namespace UI.Steps
{
    [Binding]
    public class ShoppingSD
    {
        ShoppingObj shoppingObj = new ShoppingObj();

        private readonly ScenarioContext context;
        public ShoppingSD(ScenarioContext injectedCotext)
        {
            context = injectedCotext;
        }
        [Given(@"I add four different products to my wish list")]
        public void GivenIAddFourDifferentProductsToMyWishList()
        {
            shoppingObj.addtowishlist();
        }

        [When(@"I view my wishlist table")]
        public void WhenIViewMyWishlistTable()
        {
           shoppingObj.ViewWishList();
        }

        [Then(@"I find total four selected items in my Wishlist")]
        public void ThenIFindTotalFourSelectedItemsInMyWishlist()
        {
            shoppingObj.SelectedItems();
        }

        [When(@"I search for lowest price product")]
        public void WhenISearchForLowestPriceProduct()
        {
            shoppingObj.LowestP();
        }

        [When(@"I am able to add the lowest price item to my cart")]
        public void WhenIAmAbleToAddTheLowestPriceItemToMyCart()
        {
            shoppingObj.Addlowstitemtocart();
        }

        [Then(@"I am able to verify the item in my cart")]
        public void ThenIAmAbleToVerifyTheItemInMyCart()
        {
            shoppingObj.gotoCart1();

        }


    }
}
