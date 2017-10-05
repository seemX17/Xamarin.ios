using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CustomTableView.Model;

namespace CustomTableView
{
   public static  class tableRepository
    {

        public static List<State> GetStates()
        {
            var states = new List<State>
            {
                new State
                {
                    Name = "Goa",
                    Image = "img1.jpg"
                },
                 new State
                {
                    Name = "Delhi",
                    Image ="img2.jpg"
                }


            };
            return states.OrderBy(c => c.Name).ToList();
            
        }

    }
}

