﻿using System;
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

        public Management(List<ProductReview> listProductReview)
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
        }

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

        public void CreateDataTable()
        {
            Console.WriteLine("ProductID \t UserID \t Rating \t Review \t isLike");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Console.WriteLine(dataTable.Rows[i].Field<string>("ProductID") + "\t\t"
                                + dataTable.Rows[i].Field<string>("UserID") + "\t\t"
                                + dataTable.Rows[i].Field<string>("Rating") + "\t\t"
                                + dataTable.Rows[i].Field<string>("Review") + "\t\t"
                                + dataTable.Rows[i].Field<string>("isLike")
                                );
            }

        }

        public void IsLikeTrue()
        {

            var recordData = (from rows in dataTable.AsEnumerable()
                              where rows.Field<string>("isLike") == "True"
                              select rows);

            foreach (DataRow row in recordData) 
            {
                Console.WriteLine("ProductId:{0},UserId:{1},Rating:{2},Review:{3},isLike:{4}", row["ProductId"], row["UserId"], row["Rating"], row["Review"], row["isLike"]);

            }
        }

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

        public void SimilarUserID(List<ProductReview> listProductReview)
        {
            var recordedData = from product in listProductReview
                               where product.UserID == 10
                               orderby product.Rating ascending
                               select product;
                               
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
    }

}
