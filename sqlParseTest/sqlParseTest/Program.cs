using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSQL;
using TSQL.Statements;

namespace sqlParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TSQLSelectStatement select = TSQLStatementReader.ParseStatements(@"
					SELECT OrderDateKey, SUM(SalesAmount) AS TotalSales
					FROM FactInternetSales
					GROUP BY OrderDateKey
					HAVING OrderDateKey > 20010000
					ORDER BY OrderDateKey;")[0] as TSQLSelectStatement;

            Console.ReadKey();
        }
    }
}
