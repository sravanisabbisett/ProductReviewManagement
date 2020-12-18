using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ProductReviewManagement
{
    class Management
    {

        /// <summary>
        /// Selects the top three highest rating.
        /// </summary>
        /// <param name="productReviews">The product reviews.</param>
        public void SelectTopThreeHighestRating(List<ProductReview> productReviews)
        {
            var highestRating = (from product in productReviews
                                 orderby product.Rating descending
                                 select product).Take(3);

            foreach(var list in highestRating)
            {
                Console.WriteLine(list.toString());
            }
        }
    }
}
