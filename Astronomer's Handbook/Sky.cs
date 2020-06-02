using System.Collections.Generic;
using System.Linq;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Небо. Содержит созвездия
    /// </summary>
    public class Sky 
    {
        public List<Constellation> Constellations;

        public Sky() :this(new List<Constellation>())
        {

        }

        public Sky(List<Constellation> constellations)
        {
            Constellations = constellations;
        }

        #region Ienumerator

        public IEnumerator<Constellation> GetEnumerator()
        {
            return Constellations.GetEnumerator();
        }

        public IEnumerable<Constellation> GetEnumerable()
        {
            return Constellations;
        }

        public IEnumerable<Star> GetAllStars()
        {
            return Constellations.SelectMany(c => c.Stars.ToArray());
        }

        #endregion

    }
}
