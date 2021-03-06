// This file was auto-generated by ML.NET Model Builder. 

using System;
using CustomersManagementProjectML.Model;

namespace CustomersManagementProjectML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Store_name = @"WatchOut Store",
                SerialKey = @"sd2e2opfo3s",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Rating with predicted Rating from sample data...\n\n");
            Console.WriteLine($"Store_name: {sampleData.Store_name}");
            Console.WriteLine($"SerialKey: {sampleData.SerialKey}");
            Console.WriteLine($"\n\nPredicted Rating: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
