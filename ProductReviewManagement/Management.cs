using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;



namespace ProductReviewManagement
{ 
    public class Management
    {
        DataTable dataTable = new DataTable();
        public Management()
        {
            //creating coloumns
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("isLike", typeof(bool));

            //AddRows in datatable
            dataTable.Rows.Add(1, 1, 2d, "Good", true);
            dataTable.Rows.Add(2, 2, 3d, "Nice", true);
            dataTable.Rows.Add(3, 3, 3d, "Good", true);
            dataTable.Rows.Add(4, 4, 4d, "Nice", true);
            dataTable.Rows.Add(5, 5, 3d, "Bad", false);
            dataTable.Rows.Add(6, 6, 6d, "Good", true);
            dataTable.Rows.Add(1, 7, 4d, "Good", true);
            dataTable.Rows.Add(2, 5, 4d, "Good", true);
            dataTable.Rows.Add(3, 4, 8d, "Good", true);
            dataTable.Rows.Add(10, 5, 7d,"Good", true);
            dataTable.Rows.Add(11, 1, 3d, "nice", true);
            dataTable.Rows.Add(12, 10, 5d, "Okay", true);
            dataTable.Rows.Add(13, 10, 8d, "Nice", true);
            dataTable.Rows.Add(11, 10, 2d, "Bad", false);
            dataTable.Rows.Add(15, 10, 9d, "Nice", true);
            dataTable.Rows.Add(14, 10, 7d, "Good", true);
            dataTable.Rows.Add(16, 10, 9d, "Nice", true);
            dataTable.Rows.Add(17, 10, 9d, "Nice", true);
            dataTable.Rows.Add(18, 10, 9d, "Nice", true);
            dataTable.Rows.Add(19, 10, 9d, "Nice", true);
            dataTable.Rows.Add(20, 10, 9d, "Nice", true);

        }
        

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

        /// <summary>
        /// Selects the review and identifier from list.
        /// </summary>
        /// <param name="productReviews">The product reviews.</param>
        public void SelectReviewAndIdFromList(List<ProductReview> productReviews)
        {
            var select = from products in productReviews
                         select (products.ProductID, products.Review);
            foreach(var list in select)
            {
                Console.WriteLine("ProductID:" + list.ProductID + " , Review:" + list.Review);
            }
        }

        /// <summary>
        /// Skips the top5 records.
        /// </summary>
        /// <param name="productReviews">The product reviews.</param>
        public void SkipTop5Records(List<ProductReview> productReviews)
        {
            var skipRecords = (from products in productReviews
                               select products).Skip(5);
            foreach(var list in skipRecords)
            {
                Console.WriteLine(list.toString());
            }
        }

        /// <summary>
        /// Selects the product identifier and review.
        /// </summary>
        /// <param name="productReviews">The product reviews.</param>
        public void SelectProductIdAndReview(List<ProductReview> productReviews)
        {
            var selectedRecords = productReviews.Select(x => new { x.ProductID, x.Review });

            foreach(var products in selectedRecords)
            {
                Console.WriteLine("ProductID:" + products.ProductID + " , Review:" + products.Review);
            }
        }

        /// <summary>
        /// Retrives the is like vlaue true.
        /// </summary>
        /// <param name="table">The table.</param>
        public void RetriveIsLikeVlaueTrue()
        {
            var Data = from reviews in dataTable.AsEnumerable()
                       where reviews.Field<bool>("isLike").Equals(true)
                       select reviews;

            foreach(var dataItem in Data)
            {
                Console.WriteLine($"ProductID- {dataItem.ItemArray[0]} UserID- {dataItem.ItemArray[1]} Rating- {dataItem.ItemArray[2]} Review- {dataItem.ItemArray[3]} isLike- {dataItem.ItemArray[4]}");
            }
                       
        }

        /// <summary>
        /// Averages the rating by product identifier.
        /// </summary>
        public void AverageRatingByProductID()
        {
            var Data = dataTable.AsEnumerable()
                        .GroupBy(x => x.Field<int>("ProductID"))
                        .Select(x => new { ProductID = x.Key, Average = x.Average(p => p.Field<double>("Rating")) });
            foreach (var dataItem in Data)
            {
                Console.WriteLine("Product Id: " + dataItem.ProductID + " " + "Average: " + dataItem.Average);
            }
        }

    }
}
