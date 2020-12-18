using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");
            Management management = new Management();
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=10,Rating=2,Review="Good",isLike=false},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=3,Rating=1,Review="ba4",isLike=true},
                new ProductReview(){ProductID=7,UserID=5,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=5,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=9,UserID=8,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=8,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=5,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=10,Rating=6,Review="nice",isLike=true},
                new ProductReview(){ProductID=13,UserID=12,Rating=7,Review="nice",isLike=true},
                new ProductReview(){ProductID=14,UserID=14,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=15,UserID=14,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=16,UserID=18,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=10,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=18,UserID=19,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=18,UserID=20,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=20,UserID=25,Rating=7,Review="nice",isLike=true},
                new ProductReview(){ProductID=21,UserID=20,Rating=7,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=10,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=23,UserID=20,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=25,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=20,Rating=6,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=10,Rating=11,Review="nice",isLike=true},
            };
            Console.WriteLine("Selects the top 3 records of highest rating");
            management.SelectTopThreeHighestRating(productReviewList);
            Console.WriteLine("Select records whose rating is greater than 3 for particular productId's");
            management.SelectedRecordsofRatingGreaterThan3(productReviewList);
            Console.WriteLine("Count productID using groupby");
            management.CountProductIds(productReviewList);
            Console.WriteLine("select only productId and Review from list");
            management.SelectReviewAndIdFromList(productReviewList);
            Console.Write("Skip top 5 records");
            management.SkipTop5Records(productReviewList);
            Console.WriteLine("Select only productId and Review from list");
            management.SelectProductIdAndReview(productReviewList);
            Console.WriteLine("Select only true values");
            management.RetriveIsLikeVlaueTrue();
            Console.WriteLine("Average rating by product");
            management.AverageRatingByProductID();
            Console.WriteLine("Retrive review message nice");
            management.RetriveReviewMessageNice();
            Console.WriteLine("Retrive userId 10 Order by Rating");
            management.RetriveUserId10OrderByRating();
            Console.ReadKey();
        }
    }
}
