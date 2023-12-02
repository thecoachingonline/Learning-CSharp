using Microsoft.Spark.Sql

namespace MySparkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var spark = SparkSession
                .Builder()
                .AppName("world_count_sample")
                .GetOrCreat();

            DataFrame dataFrame = spark.Read().text("input.txt");

            var world = dataFrame
                .Select(Function.Split(Function.Col("value"), "").Alias("words"))
                .Select(Function.Explode(Function.Col("world"))
                .Alias("word"))
                .GroupBy("word")
                .Count()
                .OrderBy(Function.Col("count").Desc());

                words.show();
        }
    }
}