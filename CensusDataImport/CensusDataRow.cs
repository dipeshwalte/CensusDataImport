using System;
using System.Collections.Generic;
using System.Text;

namespace CensusDataImport
{
    /// <summary>
    /// 
    /// </summary>
    class CensusDataRow
    {
        string state;
        int population;
        int area;
        int density;
        /// <summary>
        /// Initializes a new instance of the <see cref="CensusDataRow"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CensusDataRow(CensusDataRow dataRow)
        {
            this.state = dataRow.state;
            this.population = dataRow.population;
            this.area = dataRow.area;
            this.density = dataRow.density;
        }
        public CensusDataRow(string state,string population,string area,string density)
        {
            this.state = state;
            this.population = Convert.ToInt32(population);
            this.area = Convert.ToInt32(area);
            this.density = Convert.ToInt32(density);
        }
    }
}
