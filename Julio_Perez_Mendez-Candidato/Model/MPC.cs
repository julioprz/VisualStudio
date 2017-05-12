using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MPC
    {
        public List<MainPagesC> MPContent { get; set; }


        public MPC()
        {
            MPContent = new List<MainPagesC>();
        }

        public class MainPagesC
        {
            public int ID { get; set; }
            public string sTitle { get; set; }
            public string sStory { get; set; }
            public DateTime dtCreated { get; set; }
            public DateTime dtUpdated { get; set; }

            public MainPagesC()
            {
                sTitle = null;
                sStory = null;
                dtCreated = DateTime.Now;
                dtUpdated = DateTime.Now;
            }

            public void GetMainPageContent(int id)
            {
                ID = id;
            }
        }

    }
}

