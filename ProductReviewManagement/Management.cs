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

        /// <summary>
        /// Selecteds the recordsof rating greater than3.
        /// </summary>
        /// <param name="productReviews">The product reviews.</param>
        public void SelectedRecordsofRatingGreaterThan3(List<ProductReview> productReviews)
        {
            var selectedRecords = from products in productReviews
                                  where (products.ProductID == 1 || products.ProductID == 4 || products.ProductID == 9)
                                  && products.Rating > 3
                                  select products;
            foreach(var list in selectedRecords)
            {
                Console.WriteLine(list.toString());
            }
        }

        /// <summary>
        /// Counts the product ids.
        /// </summary>
        /// <param name="productReviews">The product reviews.</param>
        public void CountProductIds(List<ProductReview> productReviews)
        {
            var recordedData = productReviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID: " + list.ProductID + " " + "Count: " + list.Count);
            }
        }

    }
}
