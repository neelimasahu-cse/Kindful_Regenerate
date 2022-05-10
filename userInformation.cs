using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulitipleViews
{
    public class userInformation
    {
            private string userName;
            private int phoneNumber;
            private int quantity;
            private Cloth cloth;

            public string RecieverName
            {
                get { return userName; }
                set { userName = value; }
            }
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
            public int PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
             public Cloth Cloth
                {
                    get { return cloth; }
                    set { cloth = value; }
                }
    }
    }
