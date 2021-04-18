using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProducID == 1 || productReviews.ProducID == 4 || productReviews.ProducID == 9)
                               && productReviews.Rating > 3
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }

        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Count);
            }
        }

        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProducID + "--------" + list.Review);
            }
        }

        public void SkipRecoreds(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.UserID descending
                               select productReviews).Take(20);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }

        public void RetrieveProductIdAndRating(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProducID + "--------" + list.Rating);
            }
        }

        public void CreateDataTable(List<ProductReview> listProductReview)
        {
            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("UserID");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            foreach (var item in listProductReview)
            {
                dataTable.Rows.Add(item.ProducID,item.UserID,item.Rating,item.Review,item.isLike);
            }

            Console.WriteLine("ProductID \t UserID \t Rating \t Review \t isLike");

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(dataTable.Rows[i].Field<string>("ProductID") + "\t\t"
                                + dataTable.Rows[i].Field<string>("UserID") + "\t\t"
                                + dataTable.Rows[i].Field<string>("Rating") + "\t\t"
                                + dataTable.Rows[i].Field<string>("Review") + "\t\t"
                                + dataTable.Rows[i].Field<string>("isLike")
                                );
            }

        }

        /*public void IsLikeTrue(List<ProductReview> listProductReview)
        {
            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("UserID");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            foreach (var item in listProductReview)
            {
                dataTable.Rows.Add(item.ProducID, item.UserID, item.Rating, item.Review, item.isLike);
            }

            //Console.WriteLine("ProductID \t UserID \t Rating \t Review \t isLike");

            var productNames = from product in dataTable.AsEnumerable()
                               where product.Field<string>("isLike") == "true"
                               select product.Field<string>("isLike");

            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }

        }*/

        public void AverageRating(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Average(s => s.Rating);

            Console.WriteLine("Average Rating: " + recordedData);

        }

        public void ReviewIsNice(List<ProductReview> listProductReview)
        {
            var recordedData = from product in listProductReview
                               where product.Review == "nice"
                               select product;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
    }

}
