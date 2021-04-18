using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management");

            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProducID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProducID=2,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=3,UserID=3,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProducID=4,UserID=4,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProducID=5,UserID=5,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProducID=6,UserID=6,Rating=1,Review="bad",isLike=true},
                new ProductReview(){ProducID=8,UserID=7,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProducID=8,UserID=8,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProducID=2,UserID=9,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProducID=10,UserID=10,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProducID=11,UserID=11,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProducID=9,UserID=12,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=12,UserID=13,Rating=6,Review="nice",isLike=true},
                new ProductReview(){ProducID=13,UserID=14,Rating=7,Review="bad",isLike=true},
                new ProductReview(){ProducID=11,UserID=15,Rating=1,Review="nice",isLike=false},
                new ProductReview(){ProducID=1,UserID=16,Rating=5,Review="nice",isLike=true},
                new ProductReview(){ProducID=15,UserID=17,Rating=5,Review="bad",isLike=true},
                new ProductReview(){ProducID=19,UserID=18,Rating=0,Review="nice",isLike=false},
                new ProductReview(){ProducID=16,UserID=19,Rating=9,Review="nice",isLike=false},
                new ProductReview(){ProducID=17,UserID=20,Rating=7,Review="Good",isLike=true},
                new ProductReview(){ProducID=18,UserID=21,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=20,UserID=22,Rating=2,Review="bad",isLike=true},
                new ProductReview(){ProducID=8,UserID=23,Rating=3,Review="nice",isLike=false},
                new ProductReview(){ProducID=2,UserID=24,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProducID=5,UserID=25,Rating=0,Review="bad",isLike=true}

            };

            /*foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }*/

            //UC2
            Management management = new Management();
            //management.TopRecords(productReviewList);

            //UC3
            //management.SelectedRecords(productReviewList);

            //UC4
            //management.RetrieveCountOfRecords(productReviewList);

            //UC5
            //management.RetrieveProductIdAndReview(productReviewList);

            //UC6
            //management.SkipRecoreds(productReviewList);

            //UC7
            //management.RetrieveProductIdAndRating(productReviewList);

            //UC8
            management.CreateDataTable(productReviewList);

            Console.ReadKey();
        }


    }
}
