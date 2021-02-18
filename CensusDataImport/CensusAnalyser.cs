using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CensusDataImport
{
    /// <summary>
    /// 
    /// </summary>
    class CensusAnalyser
    {
        public Dictionary<string, CensusDataRow> datamap;
        /// <summary>
        /// Loads the census data.
        /// </summary>
        /// <param name="csvFilePath">The CSV file path.</param>
        /// <param name="dataHeaders">The data headers.</param>
        /// <returns></returns>
        /// <exception cref="Dictionary<string, CensusDataRow>"></exception>
        public Dictionary<string, CensusDataRow> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            datamap = new Dictionary<string, CensusDataRow>();
            // Throw File not exists
            // Throw Improper extension

            string[] censusData = File.ReadAllLines(csvFilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
            }
            foreach (string row in censusData)
            {
                if (!row.Contains(","))
                {
                    throw new CensusAnalyserException(CensusAnalyserException.ExceptionType.DELIMITER_NOT_FOUND, "Delimiter not found");
                }
                string[] column = row.Split(',');
                datamap.Add(column[1], new CensusDataRow(column[0], column[1], column[2], column[3]));
            }   
            return datamap;
        }
    }
}
