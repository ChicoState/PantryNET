using System;
using System.Collections.Generic;
using System.Text;

// container for the BuilderDesignPattern

namespace BuilderDesignPattern
{

    public class Report
    {
        private double count = 0.0;
        private double price = 20;
        private double totalprice = 0.0;
        public double Itemcode = 2345;
        public double Date;

        //Function to Add the item count
        public void addItemCount(double x)
        {
            count = count + x;
        }
        //Function to Get the Item count
        public double getItemCount()
        {
            return count;
        }
        //Function to calculate the price of items
        public void ItemPrice(double noofitems)
        {
            totalprice = price * noofitems;
        }
        //Function to return total price of Item
        public double getItemPrice()
        {
            return totalprice;
        }
        public double getItemCode()
        {
            return Itemcode;
        }
        public double getExpiryDate()
        {
            return Date;
        }
        public string ReportType { get; set; }
        public string ReportNoItems { get; set; }
        public string ReportContent { get; set; }
        public string ReportItemCode { get; set; }
        public string ReportDate { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("NoofItems :" + ReportNoItems);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Item Code :" + ReportItemCode);
            Console.WriteLine("Expiry Date :" + ReportDate);

        }
    }

    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportNoItems();
        public abstract void SetReportContent();
        public abstract void SetReportItemCode();
        public abstract void SetReportDate();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
    public class Expiry : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Expiry Report";
        }
        public override void SetReportNoItems()
        {
            reportObject.ReportNoItems = "10";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Expiry Report";
        }
        public override void SetReportItemCode()
        {
            reportObject.ReportItemCode = "3324";
        }
        public override void SetReportDate()
        {
            reportObject.ReportDate = "05/20/2020";
        }
    }
    public class TotalDonated : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }
        public override void SetReportNoItems()
        {

            reportObject.ReportNoItems = "10" ;
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Total Donated Food Report";
        }
        public override void SetReportItemCode()
        {
            reportObject.ReportItemCode = "3324";
        }
        public override void SetReportDate()
        {
            reportObject.ReportDate = "05/20/2020";
        }
    }
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportNoItems();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportItemCode();
            reportBuilder.SetReportDate();
            return reportBuilder.GetReport();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Client Code
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            // Construct and display Reports
            TotalDonated totaldonated = new TotalDonated();
            report = reportDirector.MakeReport(totaldonated);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            Expiry expiry = new Expiry();
            report = reportDirector.MakeReport(expiry);
            report.DisplayReport();

            Console.ReadKey();
        }
    }
}
